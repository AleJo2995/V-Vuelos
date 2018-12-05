using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos
{
    public partial class Paises : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Traer_Paises();
            }
        }

        protected void btn_nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdministrarPaises.aspx");
        }

        private void Traer_Paises()
        {

            BLL.Pais pais = new BLL.Pais();
            MC_Paises.DataSource = pais.carga_paises().Tables[0];
            MC_Paises.DataBind();
           
        }

        protected void MC_Consecutivo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            MC_Paises.PageIndex = e.NewPageIndex;
        }
    }
}