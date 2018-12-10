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
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using VVuelos.App_Code;


namespace VVuelos
{
    public partial class Login : System.Web.UI.Page
    {
        public const string FaceBookAppKey = "3fce950271a7cbbe38aaf7c7e5f96ae4";
        protected void Page_Load(object sender, EventArgs e)
        {
            captchaDiv.Visible = true;
            buttoncaptcha.Visible = true;
            Login1.Visible = false;
            if (Request.IsAuthenticated && !string.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))
                Response.Redirect("~/Default.aspx");

            if (string.IsNullOrEmpty(Request.QueryString["access_token"])) return; //ERROR! No token returned from Facebook!!

            //let's send an http-request to facebook using the token            
            string json = GetFacebookUserJSON(Request.QueryString["access_token"]);

            //and Deserialize the JSON response
            JavaScriptSerializer js = new JavaScriptSerializer();
            FacebookUser oUser = js.Deserialize<FacebookUser>(json);
            if (oUser != null)
            {
                Response.Write("Welcome, " + oUser.name);
                Response.Write("<br />id, " + oUser.id);
                Response.Write("<br />email, " + oUser.email);
                Response.Write("<br />first_name, " + oUser.first_name);
                Response.Write("<br />last_name, " + oUser.last_name);
                Response.Write("<br />gender, " + oUser.gender);
                Response.Write("<br />link, " + oUser.link);
                Response.Write("<br />updated_time, " + oUser.updated_time);
                Response.Write("<br />birthday, " + oUser.birthday);
                Response.Write("<br />locale, " + oUser.locale);
                Response.Write("<br />picture, " + oUser.picture);
                if (oUser.location != null)
                {
                    Response.Write("<br />locationid, " + oUser.location.id);
                    Response.Write("<br />location_name, " + oUser.location.name);
                }


            }
        }
        private static string GetFacebookUserJSON(string access_token)
        {
            string url = string.Format("https://graph.facebook.com/me?access_token={0}&fields=email,name,first_name,last_name,link", access_token);

            WebClient wc = new WebClient();
            Stream data = wc.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();

            return s;
        }
  

    public bool captcha()
    {
        string response = Request["g-recaptcha-response"];
        string secretkey = "6LdtcH8UAAAAAO6_ih30NRwVSRRMzSltFkh-aukW";
        bool secret = false;
        HttpWebRequest google = (HttpWebRequest)WebRequest.Create("https://www.google.com/recaptcha/api/siteverify?secret=" + secretkey + "&response=" + response);
        try
        {
            using (WebResponse web = google.GetResponse())
            {
                using (StreamReader read = new StreamReader(web.GetResponseStream()))
                {
                    string json = read.ReadToEnd();
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    CaptchaValidate check = js.Deserialize<CaptchaValidate>(json);
                    if (Convert.ToBoolean(check.success))
                    {
                        secret = true;
                    }

                }

            }
            return secret;
        }
        catch (Exception)
        {

            throw;
        }

    }


        protected void btn_captcha_Click(object sender, EventArgs e)
        {
         
            if (captcha())
            {

                Login1.Visible = true;
                captchaDiv.Visible = false;
                buttoncaptcha.Visible = false;
            }
            else
            {
                lbl_captcha.Text = "Captcha incorrecto";
            }
        }

    }
}