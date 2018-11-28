<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CambiarContraseña.aspx.cs" Inherits="VVuelos.CambiarContraseña" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
    
    <p>
        Cambio de Contraseña
    </p>

    <table class="nav-justified">
        <tr>
            <td>Contraseña:</td>
            <td>
                <asp:TextBox ID="txt_contraseña" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Nueva Contraseña:</td>
            <td>
                <asp:TextBox ID="txt_nuevaContraseña" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Confirmar Contraseña:</td>
            <td>
                <asp:TextBox ID="txt_confirmarContraseña" runat="server" Enabled="True"></asp:TextBox>
            </td>
        </tr>
        </table>
    <br />
    <asp:Button ID="btn_cambiarContraseña" runat="server" Text="Cambiar Contraseña" OnClick="btn_nuevo_Click" BackColor="#FFFFD5" BorderColor="#003399" BorderStyle="Groove" BorderWidth="3px" ForeColor="#003399" />
    <asp:Button ID="btn_Cancelar" runat="server" Text="Cancelar" OnClick="btn_nuevo_Click" BackColor="#FFFFD5" BorderColor="#003399" BorderStyle="Groove" BorderWidth="3px" ForeColor="#003399" />

</asp:Content>

