using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos
{
    public partial class NuevoConsecutivo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            BLL.Consecutivo consecutivo = new BLL.Consecutivo();
            consecutivo.descripcion = ddl_descripcion.Text;
            consecutivo.prefijo = txt_prefijo.Text;
            consecutivo.rango_final = Int32.Parse(txt_rango_fin.Text);
            consecutivo.rango_inicial = Int32.Parse(txt_rango_ini.Text);
            consecutivo.agregar_consecutivos("Insertar");
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}