using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos
{
    public partial class AdquisicionBoletos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                this.Lista_aerolineas();
            }

        }

        private void Lista_aerolineas()
        {
            BLL.Aerolinea aerolinea = new BLL.Aerolinea();
        

        }
        protected void GV_Aerolinea_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                LinkButton db = (LinkButton)e.Row.Cells[3].Controls[0];
                string nombre = e.Row.Cells[1].Text;
                db.OnClientClick = string.Format("return confirm('Confima eliminar esta aerolínea: {0}?');", nombre);
            }
        }
        protected void GV_Aerolinea_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
         
            this.Lista_aerolineas();
        }

        protected void GV_Aerolinea_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            BLL.Aerolinea aerolinea = new BLL.Aerolinea();
            if (e.CommandName.Equals("Eliminar"))
            {


                int fila = Convert.ToInt32(e.CommandArgument);
               
              

              


            }


        }

        protected void btn_nuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevaAerolinea.aspx?cod=0");
        }

    }
}