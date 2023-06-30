using MedidorModel.DAL;
using MedidorModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedInteligente_FabianCollao
{
    public partial class MostrarLecturas : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        private ILecturaDAL lecturasDAL = new LecturaDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Cargamos los medidores al dropdownList
                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                this.seleccionarMedidorList.DataSource = medidores;
                this.seleccionarMedidorList.DataTextField = "Serie";
                this.seleccionarMedidorList.DataValueField = "Serie";
                this.seleccionarMedidorList.DataBind();
                //Cargamos la grilla con las lecturas
                cargarGrilla();

            }

        }

        protected void cargarGrilla()
        {
            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();


            ///Segun el medidor seleccionado, sobreescribimos la lista de lecturas solo con los datos
            int seleccionado;
            int.TryParse(seleccionarMedidorList.SelectedValue, out seleccionado);
            if (seleccionarMedidorList.SelectedValue != "Seleccionar Medidor")
            {
                lecturas = lecturas.Where(l => l.Medidor.Serie == seleccionado).ToList();
            }
            if (lecturas.Count == 0)
            {
                this.mensajesLbl.Text = "No hay registros de lecturas";
                this.mensajesLbl.CssClass = "text-danger";
            }
            else
            {
                this.mensajesLbl.Text = "Hay "+ lecturas.Count + " lectura/s" ;
                this.mensajesLbl.CssClass = "text-success";
            }
            this.gridLecturas.DataSource = lecturas;
            this.gridLecturas.DataBind();
        }


        protected void dropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarGrilla();
        }
    }
}