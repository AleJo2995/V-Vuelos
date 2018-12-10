


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
            btn_eliminar.Visible = false;
            if (!Page.IsPostBack)
            {

                if (Convert.ToInt32(Request.QueryString["cod"]) > 0)
                {
                    this.carga_datos(Convert.ToInt32(Request.QueryString["cod"]));
                    btn_eliminar.Visible = true;
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
            bool validacion = true;
            if (FileUploadControl.HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(FileUploadControl.FileName);
                    FileUploadControl.SaveAs(Server.MapPath("~/uploads/") + filename);
                    string path = Server.MapPath("~/uploads/") + filename;
                    direccion = "~/uploads/" + filename;
                    StatusLabel.Text = "Imagen subida con éxito" + filename;
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = "No se ha podido subir la imagen debido al siguiente error:: " + ex.Message;
                }
            }


            if (string.IsNullOrWhiteSpace(txt_codigo_pais.Text))
            {
                validacion = false;
                lbl_mensaje.Text = "Debe insertar todos los datos";
            }

            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                validacion = false;
                lbl_mensaje.Text = "Debe insertar todos los datos";
            }

            if (string.IsNullOrWhiteSpace(direccion))
            {
                validacion = false;
                lbl_mensaje.Text = "Debe insertar todos los datos";
            }

            if (validacion)
            {
                pais.id = id;
                pais.id_consecutivo = 8;
                pais.codigo = Convert.ToInt32(txt_codigo_pais.Text);
                pais.nombre = txt_nombre.Text;
                pais.direccion = direccion;

                if (Convert.ToInt32(Request.QueryString["cod"]) > 0)
                {
                    pais.modifica_paises();
                    lbl_mensaje.Text = "Datos modificados con éxito";
                }
                else
                {
                    pais.agregar_paises();
                    lbl_mensaje.Text = "Datos insertados con éxito";
                }
            }
            else
            {
                lbl_mensaje.Text = "Debe insertar todos los datos";
            }


        }


        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btn_borrar_Click(object sender, EventArgs e)
        {
            direccion = "";
            txt_codigo_pais.Text = "";
            txt_nombre.Text = "";
            AdministrarPaises administrar = new AdministrarPaises();
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {

            pais.eliminar_pais(Convert.ToInt32(Request.QueryString["cod"]));
        }



    }
}
