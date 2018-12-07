using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace VVuelos
{
    public partial class AerolineaPorPais : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
              


            }
        }


      

        private void Traer_Aerolineas(int codigo_pais)
        {

            BLL.Aerolinea aerolinea = new BLL.Aerolinea();
            GV_Aerolinea.DataSource = aerolinea.carga_aerolinea_por_pais(codigo_pais).Tables[0];
            GV_Aerolinea.DataBind();

            
        }

        protected void GV_Aerolinea_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GV_Aerolinea.PageIndex = e.NewPageIndex;
        }


        protected void btn_buscar_Click(object sender, EventArgs e)
        {

            if (ddl_codigo.SelectedItem != null)
            {
                int codigo_pais = Int32.Parse(ddl_codigo.SelectedValue.ToString());
                Traer_Aerolineas(codigo_pais);
            }
            else
            {

            }


        }
    }
}