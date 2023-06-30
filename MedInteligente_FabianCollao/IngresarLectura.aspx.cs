using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedidorModel.DAL;
using MedidorModel.DTO;

namespace MedInteligente_FabianCollao
{
    public partial class IngresarLectura : System.Web.UI.Page
    {
        //Referencias de Instancias DAL
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        private ILecturaDAL lecturaDAL = new LecturaDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Cargar los medidores al dropdownList siempre que existan datos
                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                if (medidores.Count() == 0)
                {
                    this.mensajesLbl.Text = "No hay ningún medidor, ingrese al menos un medidor primero.";
                }
                else
                {
                    this.medidorList.DataSource = medidores;
                    this.medidorList.DataTextField = "Serie";
                    this.medidorList.DataValueField = "Serie";
                    this.medidorList.DataBind();
                }
                //Fecha actual para el calendario asp
                this.fechaCalendario.SelectedDate = DateTime.Now;
            }

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //Obteniendo datos ingresados
                DateTime fechaLectura = Convert.ToDateTime(this.fechaCalendario.SelectedDate);
                string horaLectura = this.horaTxtBox.Text + ":" + this.minutoTxtBox.Text;

                string medidorValor = this.medidorList.SelectedValue;

                //Validaciones del Servidor
                string medidorText = this.medidorList.SelectedItem.Text;
                if (string.IsNullOrEmpty(medidorText) || medidorText.Trim() == "Seleccione un Medidor")
                {
                    this.mensajesLbl.Text = "Selecciona un medidor";
                    return;
                }


                // Validacion de la hora
                int hora;
                if (!int.TryParse(this.horaTxtBox.Text, out hora) || hora < 0 || hora > 23)
                {
                   this.mensajesLbl.Text = "La hora debe estar entre 0 y 23.";
                    return;
                }

                // Validacion de los minutos
                int minuto;
                if (!int.TryParse(this.minutoTxtBox.Text, out minuto) || minuto < 0 || minuto > 59)
                {
                    this.mensajesLbl.Text = "El valor del minuto debe estar entre 0 y 59.";
                    return;
                }

                // Validamos el campo valor de consumo
                decimal valorConsumo;
                if (!decimal.TryParse(this.consumoTxtBox.Text, out valorConsumo) || valorConsumo < 0 || valorConsumo > 600)
                {
                    this.mensajesLbl.Text = "El valor del consumo debe estar entre 0 y 600.";
                    return;
                }

                // Obtenemos todos los medidores
                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                int medidorSeleccionado;
                int.TryParse(this.medidorList.SelectedItem.Value, out medidorSeleccionado);

                //Buscamos el medidor seleccionado en el dropDownList en la lista de medidores
                Medidor medidor = medidores.Find(m => m.Serie == medidorSeleccionado );

                //Instanciamos una nueva lectura
                Lectura lectura = new Lectura()
                {
                    Medidor = medidor,
                    FechaLectura = fechaLectura,
                    HoraLectura = horaLectura,
                    ValorConsumo = valorConsumo
                };

                // Agredamos la lectura mediante DAL
                lecturaDAL.AgregarLectura(lectura);

                Response.Redirect("MostrarLecturas.aspx");
            }
        }

    }
}