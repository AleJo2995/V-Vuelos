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
using BotDetect.Web.UI;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;


namespace VVuelos
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Login1.Visible = true;
            if (Request.IsAuthenticated && !string.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))
                Response.Redirect("~/Default.aspx");

            
         }
        
        public bool captcha()
        {
            string response = Request("g-recaptcha-response");
            string secretkey = "6Lc_sn0UAAAAACI_YPmNcw6aY87fNWeU1NwuaAu9";
            bool secret = false;
            HttpWebRequest google = (HttpWebRequest)WebRequest.Create("https://www.google.com/recaptcha/api/siteverify?secret=" + secretkey + "&response=" + response);
            try
            {
                using (WebResponse web = google.GetResponse()) ;
                {
                    using (StreamReader read = new StreamReader(web.GetResponseStream()));
                    {
                        string json = readStream.ReadToEnd();
                        JavaScriptSerializer js = new JavaScriptSerializer();
                        CaptchaValidate data = js.Deserialize<CaptchaValidate>(json);
                    }
                    secret = Convert.ToBoolean(data.success);
                }
                return secret;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}