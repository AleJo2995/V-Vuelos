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
    public partial class Salidas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

         
            if (!Page.IsPostBack)
            {
              
                Traer_Vuelos();
            }
        }
        
        private void Traer_Vuelos()
        {
            System.Threading.Thread.Sleep(1400);
            BLL.Vuelo vuelo = new BLL.Vuelo();
            MC_Salidas.DataSource = vuelo.carga_vuelos().Tables[0];
            MC_Salidas.DataBind();



        }

        protected void MC_Salidas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            MC_Salidas.PageIndex = e.NewPageIndex;
        }


    }
}