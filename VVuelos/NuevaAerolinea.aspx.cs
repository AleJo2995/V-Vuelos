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
    public partial class NuevaAerolinea : System.Web.UI.Page
    {

        BLL.Aerolinea aerolinea = new BLL.Aerolinea();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
              
                if (Convert.ToInt32(Request.QueryString["cod"]) > 0)
                {
                    this.carga_datos(Convert.ToInt32(Request.QueryString["cod"]));
                }
            }
        }

        private void carga_datos(int ID)
        {

            aerolinea.carga_datos_aerolinea(ID);
            if (aerolinea.nombre != "Error")
            {
                txt_codigo.Text = aerolinea.codigo.ToString();
                txt_codigo_pais.Text = aerolinea.codigo_pais.ToString();
                txt_nombre.Text = aerolinea.nombre;
                txt_direccion_imagen.Text = aerolinea.direccion_imagen;
               
            }
            else
            {
                //insertar en la tabla de errores
                int numero_error = aerolinea.num_error;
                string mensaje_error = aerolinea.mensaje;

                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                return;
            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            aerolinea.id= Convert.ToInt32(Request.QueryString["cod"]);
            aerolinea.id_consecutivo = 1;
            aerolinea.codigo = Convert.ToInt32(txt_codigo.Text);
            aerolinea.codigo_pais = Convert.ToInt32(txt_codigo_pais.Text);
            aerolinea.nombre = txt_nombre.Text;
            aerolinea.direccion_imagen = txt_direccion_imagen.Text;
 
            if (Convert.ToInt32(Request.QueryString["cod"]) > 0)
            {
                aerolinea.modifica_aerolinea();
            }
            else
            {
                aerolinea.agregar_aerolinea();
            }       
       
         
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}