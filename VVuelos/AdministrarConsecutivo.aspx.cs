﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos
{
    public partial class AdministrarConsecutivo : System.Web.UI.Page
    {
  
        BLL.Consecutivo consecutivo = new BLL.Consecutivo();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddl_descripcion.DataSource = consecutivo.lista_consecutivos();
                ddl_descripcion.DataBind();
                if (Convert.ToInt32(Request.QueryString["cod"]) > 0)
                {
                    this.carga_datos(Convert.ToInt32(Request.QueryString["cod"]));
                }
            }

        }

        private void carga_datos(int ID)
        {

            consecutivo.datos_consecutivos(ID);
            if (consecutivo.descripcion != "Error")
            {
                txt_rango_ini.Visible = true;
                txt_rango_fin.Visible = true;
                txt_prefijo.Visible = true;
                txt_consecutivo.ReadOnly = true;
                txt_consecutivo.Text = consecutivo.consecutivo.ToString();
                ddl_descripcion.SelectedValue = consecutivo.descripcion;
                txt_prefijo.Text = consecutivo.prefijo;
                txt_rango_ini.Text = consecutivo.rango_inicial.ToString();
                txt_rango_fin.Text = consecutivo.rango_final.ToString();

            }
            else
            {
                //insertar en la tabla de errores
                int numero_error = consecutivo.num_error;
                string mensaje_error = consecutivo.mensaje;

                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                return;
            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            BLL.Consecutivo consecutivo = new BLL.Consecutivo();
            consecutivo.id = Convert.ToInt32(Request.QueryString["cod"]);
            consecutivo.consecutivo = Int32.Parse(txt_consecutivo.Text);
            consecutivo.descripcion = ddl_descripcion.Text;

            if (string.IsNullOrWhiteSpace(txt_prefijo.Text))
            {
                consecutivo.prefijo = null;
            }
            else
            {
                consecutivo.prefijo = txt_prefijo.Text;
            
            }
            if (string.IsNullOrWhiteSpace(txt_rango_fin.Text))
            {
                consecutivo.rango_final = 0 ;
            }
            else
            {
                consecutivo.rango_final = Int32.Parse(txt_rango_fin.Text);
      
            }
            if (string.IsNullOrWhiteSpace(txt_rango_ini.Text))
            {
                consecutivo.rango_inicial = 0;
            }
            else
            {
                consecutivo.rango_inicial = Int32.Parse(txt_rango_ini.Text);
            }



            if (Convert.ToInt32(Request.QueryString["cod"]) > 0)
            {
                consecutivo.modifica_consecutivos();
            }
            else
            {
                consecutivo.agregar_consecutivos();
            }


        }
            

  

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {

            Response.Redirect("Default.aspx");

        }
    }
}