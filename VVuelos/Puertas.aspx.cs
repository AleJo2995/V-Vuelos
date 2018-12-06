using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos
{
    public partial class Puertas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!User.IsInRole("Administrador"))
                MC_Puertas.Columns[3].Visible = false;
                btn_nuevo.Visible = false;

            if (!Page.IsPostBack)
            {
                Traer_Puertas();
            }
        }

        protected void btn_nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdministrarPuertas.aspx");
        }

        private void Traer_Puertas()
        {

            BLL.Puertas_Aeropuerto puertas = new BLL.Puertas_Aeropuerto();
            MC_Puertas.DataSource = puertas.carga_puertas().Tables[0];
            MC_Puertas.DataBind();

        }

        protected void MC_Puertas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            MC_Puertas.PageIndex = e.NewPageIndex;
        }
    }
}