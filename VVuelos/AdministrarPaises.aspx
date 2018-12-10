<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministrarPaises.aspx.cs" Inherits="VVuelos.AdministrarPaises" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="nav-justified">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Código País:</td>
        <td>
            <asp:TextBox ID="txt_codigo_pais" runat="server"></asp:TextBox>
            <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" 
 ControlToValidate="txt_codigo_pais" ErrorMessage="Debe ingresar un número." />
            </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Nombre:</td>
        <td>
            <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <br />
            <br />
        </td>
        <td>
             <asp:Label ID="lbl_mensaje" runat="server" ForeColor="Red"></asp:Label>
             &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_guardar" runat="server" OnClick="btn_guardar_Click" Text="Guardar" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_cancelar" runat="server" OnClick="btn_cancelar_Click" Text="Cancelar" />
              &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_borrar" runat="server" OnClick="btn_borrar_Click" Text="Borrar" />
             &nbsp;&nbsp;&nbsp;
              <asp:Button ID="btn_eliminar" runat="server" OnClick="btn_eliminar_Click" Text="Eliminar" />
            <asp:FileUpload id="FileUploadControl" runat="server" />
    <asp:Label runat="server" id="StatusLabel" text="Upload status: " />    
        </td>
    </tr>
</table>

</asp:Content>


