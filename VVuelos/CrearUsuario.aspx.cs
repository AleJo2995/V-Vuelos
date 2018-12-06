using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void ContinueButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Request.QueryString["cod"]) == 1)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Redirect("LoginReservacion.aspx");
            }
            
        }
    }
}