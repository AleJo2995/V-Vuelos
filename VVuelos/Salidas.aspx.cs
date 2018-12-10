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
        BLL.Vuelo vuelo = new BLL.Vuelo();
        protected void Page_Load(object sender, EventArgs e)
        {

         
            if (!Page.IsPostBack)
            {
              
                Traer_Vuelos();
            }
        }
        
        private void Traer_Vuelos()
        {
          
          
            GV_Salidas.DataSource = vuelo.carga_vuelos_salida().Tables[0];
            GV_Salidas.DataBind();



        }

        protected void MC_Salidas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GV_Salidas.PageIndex = e.NewPageIndex;
            Traer_Vuelos();
        }


    }
}