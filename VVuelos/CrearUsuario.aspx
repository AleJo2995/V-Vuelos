<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="VVuelos.CrearUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>

    <p>
        Crear nueva cuenta</p>

    <table class="nav-justified">
        <tr>
            <td>Usuario:</td>
            <td>
                <asp:TextBox ID="txt_usuario" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Contraseña:</td>
            <td>
                <asp:TextBox ID="txt_contraseña" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Confirmar Contraseña:</td>
            <td>
                <asp:TextBox ID="txt_confirmarContraseña" runat="server" Enabled="True"></asp:TextBox>
            </td>
        </tr>
        
             <tr>
            <td>E-mail:</td>
            <td>
                <asp:TextBox ID="txt_email" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
             <tr>
            <td>Pregunta de Seguridad:</td>
            <td>
                <asp:TextBox ID="txt_perguntaDeSeguridad" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
             <tr>
            <td>Respuesta de Seguridad:</td>
            <td>
                <asp:TextBox ID="txt_respuestaDeSeguridad" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>

    </table>
    <br />
    <asp:Button ID="btn_nuevo" runat="server" Text="Crear usuario" OnClick="btn_nuevo_Click" BackColor="#FFFFD5" BorderColor="#003399" BorderStyle="Groove" BorderWidth="3px" ForeColor="#003399" />
</asp:Content>

