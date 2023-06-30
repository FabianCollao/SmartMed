using MedidorModel.DAL;
using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedInteligente_FabianCollao
{
    public partial class IngresarMedidor : System.Web.UI.Page
    {

        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //Obtencion y validacion de datos ingresados
                string tipo = this.tipoTxtBox.Text.Trim();
                //validación numero de serie
                int serie = 0;
                if (!int.TryParse(this.serieTxtBox.Text.Trim(), out serie)) {
                    this.mensajesLbl.Text = "Ingresa solo números en el campo serie";
                        return;
                }
                //Validacion tipo de medidor
                if (string.IsNullOrEmpty(tipo))
                {
                    this.mensajesLbl.Text = "El campo 'tipo' no puede estar vacío.";
                    return;
                }
                //Validacion de campo vacio del # de serie
                if (string.IsNullOrEmpty(this.serieTxtBox.Text.Trim()))
                {
                    this.mensajesLbl.Text = "El campo 'serie' no puede estar vacío";
                    return;
                }
                //Obtenemos la lista de medidores
                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                Medidor encontrado = medidores.Find(m=> m.Serie == serie);
                if (medidores.Contains(encontrado))
                {
                    this.mensajesLbl.Text = "¡Este número de serie ya existe!";
                    return;
                }
                //Construir el objeto tipo
                Medidor medidor = new Medidor()
                {
                    Tipo = tipo,
                    Serie = serie
                };

                // Llamar al DAL
                medidorDAL.AgregarMedidor(medidor);
                // Mostrar mensaje de exito
                this.mensajesLbl.Text = "Medidor Guardado Correctamente";
                this.mensajesLbl.CssClass = "txt-succes";
                Response.Redirect("MostrarMedidores.aspx");
            }
        }
    }
}