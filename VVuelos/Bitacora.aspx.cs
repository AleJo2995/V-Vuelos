using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos
{
    public partial class Bitacora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Traer_Bitacora();
            }
        }

        private void Traer_Bitacora()
        {

            BLL.Bitacora bitacora = new BLL.Bitacora();
            GV_Bitacora.DataSource = bitacora.carga_bitacora().Tables[0];
            GV_Bitacora.DataBind();

        }

        protected void MC_Bitacora_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GV_Bitacora.PageIndex = e.NewPageIndex;
            Traer_Bitacora();
        }
    }
}