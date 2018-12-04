using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace VVuelos
{
    public partial class Error : System.Web.UI.Page
    {
        BLL.Error error = new BLL.Error();

        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_error.Text = "Se ha presentado un error. Número de Error: " + Request.QueryString["error"].ToString() + " " + Request.QueryString["men"].ToString();

            error.numero = Convert.ToInt32(Request.QueryString["error"]);
            error.descripcion = Request.QueryString["men"].ToString();
            error.agregar_errores();


        }
    }
}