<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="LoginBoletos.aspx.cs" Inherits="VVuelos.LoginBoletos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <asp:Login ID="Login1" runat="server" DisplayRememberMe="False" Width="363px" Forecolor="Black" DestinationPageUrl="~/AdquisicionBoletos.aspx">
      </asp:Login>   
    
    <a href="/CrearUsuario.aspx?cod=0">Crear usuario</a>
           <a href="/RecuperarContraseña.aspx>"> ¿Olvidó la contraseña?</a>


</asp:Content>
