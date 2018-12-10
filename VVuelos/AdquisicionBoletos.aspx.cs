using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos
{
    public partial class AdquisicionBoletos : System.Web.UI.Page
    {
        BLL.Pais pais = new BLL.Pais();
        static String direccion;
        static int id;
        BLL.Vuelo vuelo = new BLL.Vuelo();


        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        private void carga_datos(int ID)
        {


         
            vuelo.carga_vuelos_salida();
            ddl_destino.DataSource = vuelo.destino;
       
        }



        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }


    
    }
}