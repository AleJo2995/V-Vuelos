using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VVuelos.ServiceReference1;

namespace VVuelos
{
    public partial class AdministrarMetodosPago : System.Web.UI.Page
    {
        ServiceClient client = new ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!Page.IsPostBack)
            {
                Traer_Tarjetas();
            }

        }

        private void Traer_Tarjetas()
        {

            
            GV_Tarjetas.DataSource = client.cargarTarjeta("admin").Tables[0];
            GV_Tarjetas.DataBind();

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {

         
            client.insertarTarjeta("admin", 6383, 02, 20, 333, 1000000, "visa", "débito");
           
        }

        protected void btn_lista_Click(object sender, EventArgs e)
        {

            string retorno = client.devolverTarjeta(1);

            var objeto = JsonConvert.DeserializeObject<dynamic>(retorno);

            lbl_usuario.Text = objeto["usuario"];
           

        }

        protected void GV_Tarjetas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Traer_Tarjetas();
            GV_Tarjetas.PageIndex = e.NewPageIndex;
        }


    }
}