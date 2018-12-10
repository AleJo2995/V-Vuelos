<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministrarAerolinea.aspx.cs" Inherits="VVuelos.AdministrarAerolinea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <table class="nav-justified">
    <tr>
        <td style="height: 19px">&nbsp;</td>
        <td style="height: 19px">
        </td>
    </tr>
    <tr>
        <td style="height: 26px">Código:</td>
        <td style="height: 26px">
            <asp:TextBox ID="txt_codigo" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator ID="txt_codigo" runat="server" ControlToValidate="txt_codigo" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True">Este campo es requerido</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Código_País:</td>
        <td>
            <asp:TextBox ID="txt_codigo_pais" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator ID="txt_codigo_pais" runat="server" ControlToValidate="txt_codigo_pais" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True">Este campo es requerido</asp:RequiredFieldValidator>
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
			<asp:RequiredFieldValidator ID="txt_nombre" runat="server" ControlToValidate="txt_nombre" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True">Este campo es requerido</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>

        <td>&nbsp;</td>
        <td>
             <asp:Label ID="lbl_mensaje" runat="server" ForeColor="Black"></asp:Label>
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