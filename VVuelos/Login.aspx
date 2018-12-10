<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VVuelos.Login"  %>

<html>

<head runat="server">


<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
body {font-family: Arial, Helvetica, sans-serif;}
form {border: 3px solid #f1f1f1;}

input[type=text], input[type=password] {
    width: 100%;
    padding: 12px 20px;
    margin: 8px 0;
    display: inline-block;
    border: 1px solid #ccc;
    box-sizing: border-box;
}

button {
    background-color: #4CAF50;
    color: white;
    padding: 14px 20px;
    margin: 8px 0;
    border: none;
    cursor: pointer;
    width: 100%;
}

button:hover {
    opacity: 0.8;
}

.cancelbtn {
    width: auto;
    padding: 10px 18px;
    background-color: #f44336;
}

.imgcontainer {
    text-align: center;
    margin: 24px 0 12px 0;
}

img.avatar {
    width: 40%;
    border-radius: 50%;
}

.container {
    padding: 16px;
}

span.psw {
    float: right;
    padding-top: 16px;
}

span.crt {
    float: left;
    padding-top: 16px;
}
/* Change styles for span and cancel button on extra small screens */
@media screen and (max-width: 300px) {
    span.psw {
       display: block;
       float: none;
    }
    .cancelbtn {
       width: 100%;
    }
}
</style>

    
    <script src='https://www.google.com/recaptcha/api.js'></script>



    <%-- now this is some required facebook's JS, two things to pay attention to
    1. setting the ApplicationID, To make this project work you have to edit "callback.aspx.cs" and put your facebook-app-key there
    2. Adjust the permissions you want to get from user, set that in scope options below. --%>
    <script type="text/javascript">
        window.fbAsyncInit = function () {
            FB.init({
                appId: '191743085107639',
                status: true, // check login status
                cookie: true, // enable cookies to allow the server to access the session
                xfbml: true, // parse XFBML
                oauth: true // enable OAuth 2.0
            });
        };
        (function () {
            var e = document.createElement('script'); e.async = true;
            e.src = document.location.protocol +
            '//connect.facebook.net/en_US/all.js';
            document.getElementById('fb-root').appendChild(e);
        }());

        function loginByFacebook() {
            FB.login(function (response) {
                if (response.authResponse) {
                    FacebookLoggedIn(response);
                } else {
                    console.log('User cancelled login or did not fully authorize.');
                }
            }, { scope: 'user_birthday,user_hometown,user_location,email' });
        }

        function FacebookLoggedIn(response) {
            var loc = '/default.aspx';
            if (loc.indexOf('?') > -1)
                window.location = loc + '&authprv=facebook&access_token=' + response.authResponse.accessToken;
            else
                window.location = loc + '?authprv=facebook&access_token=' + response.authResponse.accessToken;
        }
    </script>


</head>
<body >


        
<h2>VVuelos</h2>

<form id="form1" runat="server">

  

  <div class="imgcontainer">
    <img src="Imagenes/Ulacit.png" alt="Avatar" class="avatar">
  </div>

  <div class="container">
    
  <asp:Login ID="Login1" runat="server" DisplayRememberMe="False" Width="954px" DestinationPageUrl="~/Default.aspx" >
      </asp:Login> 

      <div runat="server" id="captchaDiv" Visible="true">
      <div class="g-recaptcha" data-sitekey="6LdtcH8UAAAAAKETa_PKgf8R8YA6j2siw4gkUyNO" align="center"></div>
      </div>

      </div>
     <div align="center">
          <asp:Button ID="btn_captcha" runat="server" Text="Validar captcha" OnClick="btn_captcha_Click"  />
  <asp:Label ID="lbl_captcha" runat="server" ForeColor="Red" align="center"></asp:Label>
     </div>


  <div class="container" style="background-color:#f1f1f1">
     <span class="crt"><a href="/CrearUsuario.aspx?cod=1">Crear usuario</a></span>
     
  </div>

    
</form>

</body>
</html>
