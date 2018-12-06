using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos
{
    public partial class AdministrarPuertas : System.Web.UI.Page
    {
        BLL.Puertas_Aeropuerto puertas = new BLL.Puertas_Aeropuerto();
        static int id;

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

            puertas.datos_puertas(ID);
            if (puertas.tipo_puerta != "Error")
            {

                txt_codigo.Text = puertas.codigo_puerta.ToString();
                txt_numero.Text = puertas.numero_puerta.ToString();
                txt_tipo.Text = puertas.tipo_puerta;
                txt_condicion.Text = puertas.condicion_puerta;
                id = puertas.id;

            }
            else
            {
                //insertar en la tabla de errores
                int numero_error = puertas.num_error;
                string mensaje_error = puertas.mensaje;

                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                return;
            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
         

            puertas.id = id;
            puertas.id_consecutivo = 12;
            puertas.codigo_puerta = Convert.ToInt32(txt_codigo.Text);
            puertas.numero_puerta = Convert.ToInt32(txt_numero.Text);
            puertas.tipo_puerta = txt_tipo.Text;
            puertas.condicion_puerta = txt_condicion.Text;

            if (Convert.ToInt32(Request.QueryString["cod"]) > 0)
            {
                puertas.modifica_puertas();
            }
            else
            {
                puertas.agregar_puertas();
            }


        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}