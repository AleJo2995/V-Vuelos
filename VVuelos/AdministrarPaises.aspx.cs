using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace VVuelos
{
    public partial class AdministrarPaises : System.Web.UI.Page
    {

        BLL.Pais pais = new BLL.Pais();
        static String direccion;
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

            pais.datos_paises(ID);
            if (pais.nombre != "Error")
            {
               
                txt_codigo_pais.Text = pais.codigo.ToString();
                txt_nombre.Text = pais.nombre;
                id = pais.id;
           
               
            }
            else
            {
                //insertar en la tabla de errores
                int numero_error = pais.num_error;
                string mensaje_error = pais.mensaje;

                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                return;
            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            txt_direccion_imagen.Text = id.ToString();
            if (FileUploadControl.HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(FileUploadControl.FileName);
                    FileUploadControl.SaveAs(Server.MapPath("~/uploads/") + filename);
                    string path = Server.MapPath("~/uploads/") + filename;
                    direccion = path;
                    StatusLabel.Text = "Imagen subida con éxito";
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "No se ha podido subir la imagen debido al siguiente error:: " + ex.Message;
                }
            }

            pais.id = id;
            pais.id_consecutivo = 8;
            pais.codigo = Convert.ToInt32(txt_codigo_pais.Text);
            pais.nombre = txt_nombre.Text;
            pais.direccion = direccion;

            if (Convert.ToInt32(Request.QueryString["cod"]) > 0)
            {
                pais.modifica_paises();
            }
            else
            {
                pais.agregar_paises();
            }


        }

        protected void btn_cargar_Click(object sender, EventArgs e)
        {

            
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}