using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BLL;

namespace VVuelos
{
    
    public partial class Consecutivo : System.Web.UI.Page

       
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Traer_Consecutivos();
            }
        }

        protected void btn_nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevoConsecutivo.aspx");
        }

        private void Traer_Consecutivos()
        {
           
        BLL.Consecutivo consecutivo = new BLL.Consecutivo();
            MC_Consecutivo.DataSource = consecutivo.lista_consecutivos().Tables[0];
            MC_Consecutivo.DataBind();
            
        }

        protected void MC_Consecutivo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            MC_Consecutivo.PageIndex = e.NewPageIndex;
        }

    }
}
