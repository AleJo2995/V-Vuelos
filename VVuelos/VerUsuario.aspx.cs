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



    public partial class VerUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.usuarios();
                this.roles();
            }
            string usuario = Membership.GetUser().UserName;

            if (!Roles.IsUserInRole(usuario, "Administrador"))
            {
                

                    if (!Roles.IsUserInRole(usuario, "Seguridad"))
                    {
                        int numero_error = 1;
                        string mensaje_error = "No tiene permisos para acceder";

                        HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                    }
                    
            }
        }

        private void usuarios()
        {
            lst_usuario.DataSource = Membership.GetAllUsers();
            lst_usuario.DataBind();
            Roles.IsUserInRole(Membership.GetUser().UserName, "Seguridad");
        }

        private void roles()
        {
            string[] lista_roles = Roles.GetAllRoles();
            chkl_roles.DataSource = lista_roles;
            chkl_roles.DataBind();

        }

        private void usuarios_roles(string usuario)
        {
            this.roles();

            string rol1 = String.Empty;
            string rol2 = String.Empty;
            string[] lista_roles = Roles.GetRolesForUser(usuario);

            for (int i = 0; i <= lista_roles.Length - 1; i++)
            {
                rol1 = lista_roles[i].ToString();
                for (int j = 0; j <= chkl_roles.Items.Count - 1; j++)
                {
                    rol2 = chkl_roles.Items[j].Text;
                    if (rol1.Equals(rol2))
                    {
                        chkl_roles.Items[j].Selected = true;
                    }
                }
            }
        }

        private void guardar_roles(string usuario)
        {
            string[] lista_roles = Roles.GetRolesForUser(usuario);
            string nombre_rol = "";

            if (lista_roles.Length > 0)
            {
                Roles.RemoveUserFromRoles(usuario, lista_roles);
                for (int i = 0; i <= chkl_roles.Items.Count - 1; i++)
                {
                    if (chkl_roles.Items[i].Selected)
                    {
                        nombre_rol = chkl_roles.Items[i].Text;
                        Roles.AddUserToRole(usuario, nombre_rol);
                    }
                }
            }
            else
            {
                int numero_error = 2;
                string mensaje_error = "No hay roles asignados.";

                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                return;
            }
        }

        protected void lst_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            this.usuarios_roles(lst_usuario.SelectedItem.Text);
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            this.guardar_roles(lst_usuario.SelectedItem.Text);
            UpdateData.Update();
        }

     
    }

