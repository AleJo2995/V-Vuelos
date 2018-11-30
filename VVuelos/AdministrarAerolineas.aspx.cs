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
    public partial class AdministrarAerolineas : System.Web.UI.Page
    {

        BLL.Aerolinea aerolinea = new BLL.Aerolinea();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            aerolinea.id = Convert.ToInt32(txt_id.Text);
            aerolinea.id_consecutivo = 1;
            aerolinea.codigo = Convert.ToInt32(txt_codigo.Text);
            aerolinea.codigo_pais = Convert.ToInt32(txt_codigo_pais.Text);
            aerolinea.nombre = txt_nombre.Text;
            aerolinea.direccion_imagen = txt_direccion_imagen.Text;
            
            if (aerolinea.agregar_aerolinea("Insertar"))
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}