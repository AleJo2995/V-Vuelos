using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos
{
    public partial class Entradas : System.Web.UI.Page
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
            GV_Entradas.DataSource = vuelo.carga_vuelos_entrada().Tables[0];
            GV_Entradas.DataBind();



        }

        protected void MC_Salidas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GV_Entradas.PageIndex = e.NewPageIndex;
            Traer_Vuelos();
        }
    }
}