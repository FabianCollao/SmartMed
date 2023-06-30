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
    public partial class MostrarMedidores : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //obtenemos todos los medidores
                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                //Filtramos para que el dropdownlist solo muestre 1 tipo de medidor
                medidores = medidores.GroupBy(medidor => medidor.Tipo).Select(grupo => grupo.FirstOrDefault()).ToList();
                this.seleccionarMedidorList.DataSource = medidores;
                this.seleccionarMedidorList.DataTextField = "Tipo";
                this.seleccionarMedidorList.DataValueField = "Tipo";
                this.seleccionarMedidorList.DataBind();
                cargarGrid();
            }
        }

        protected void cargarGrid()
        {
            List<Medidor> medidores = medidorDAL.ObtenerMedidores();

            // Filtrar las lecturas por el medidor seleccionado
            String seleccionado = seleccionarMedidorList.SelectedValue;

            if (medidores.Count == 0)
            {
                this.mensajesLbl.Text = "No hay registros de Medidores";
            }
            if (seleccionarMedidorList.SelectedValue != "Seleccionar Medidor")
            {
                medidores = medidores.Where(m => m.Tipo == seleccionado).ToList();
            }
            this.gridMedidor.DataSource = medidores;
            this.gridMedidor.DataBind();
        }

        protected void dropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarGrid();
        }
    }
}