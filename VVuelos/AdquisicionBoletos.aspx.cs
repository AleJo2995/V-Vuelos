using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos
{
    public partial class AdquisicionBoletos : System.Web.UI.Page
    {

        
        BLL.Vuelo vuelo = new BLL.Vuelo();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                    this.carga_datos();
                txt_boletos.Text = "0";
                txt_boletos.ReadOnly = true;
                   
            }
        }

        private void carga_datos()
        {

          
            ddl_destino.DataSource = vuelo.carga_vuelos_salida();
            ddl_destino.DataBind();
       
        }

        protected void btn_select_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(ddl_destino.SelectedValue);
            vuelo.datos_vuelos(codigo);
            lbl_cantidad_string.Text = "Cantidad de boletos disponibles";
            lbl_cantidad.Text = vuelo.numero_boletos.ToString();
            lbl_precio_string.Text = "Precio unitario";
            lbl_precio.Text = vuelo.precio.ToString();
            txt_boletos.ReadOnly = false;
        }

        protected void btn_pago_tarjeta_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompraBoletos.aspx");
        }

        protected void btn_pago_easy_pay_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompraBoletos.aspx");
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btn_reservacion_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(ddl_destino.SelectedValue);
            vuelo.datos_vuelos(codigo);
            lbl_cantidad.Text = vuelo.numero_boletos.ToString();
            lbl_precio.Text = vuelo.precio.ToString();
        }


    }
}