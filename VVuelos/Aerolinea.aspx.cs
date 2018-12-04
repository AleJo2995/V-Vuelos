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


    public partial class Aerolinea : System.Web.UI.Page
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
            GV_Aerolinea.DataSource = aerolinea.carga_aerolineas().Tables[0];
            GV_Aerolinea.DataBind();
           
            
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
            GV_Aerolinea.PageIndex = e.NewPageIndex;
            this.Lista_aerolineas();
        }
    
        protected void GV_Aerolinea_RowCommand(object sender, GridViewCommandEventArgs e)
        {
      
        BLL.Aerolinea aerolinea = new BLL.Aerolinea();
            if (e.CommandName == "Eliminar")
        {
            

            int fila = Convert.ToInt32(e.CommandArgument);
                int ID = Convert.ToInt32(GV_Aerolinea.DataKeys[fila].Value);
                if (aerolinea.eliminar_aerolinea(ID))
                {
                    this.Lista_aerolineas();
               
            }
          
            }


        }

        protected void btn_nuevo_Click(object sender, EventArgs e)
        {
        Response.Redirect("NuevaAerolinea.aspx?cod=0");
    }
    }
   
