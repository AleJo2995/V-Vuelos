<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerUsuario.aspx.cs" Inherits="VVuelos.VerUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
    <table class="nav-justified" style="width: 86%; height: 265px">
    <tr>
        <td class="auto-style1" style="width: 146px">
            <asp:Label ID="Label2" runat="server" Text="Lista de usuarios"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Lista de Roles"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style1" rowspan="3" style="width: 146px">
            <asp:ListBox ID="lst_usuario" runat="server" Height="223px" Width="135px"></asp:ListBox>
        </td>
        <td style="height: 122px">
            <asp:CheckBoxList ID="chkl_roles" runat="server" Height="167px" Width="158px">
            </asp:CheckBoxList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/" />
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Actualizando..."></asp:Label>
            <table __designer:mapid="14" border="0" cellpadding="1" cellspacing="1">
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btn_actualizar" runat="server" Text="Actualizar Roles"/>
        </td>
    </tr>
</table>
</asp:Content>