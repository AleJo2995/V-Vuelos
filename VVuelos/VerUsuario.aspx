<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerUsuario.aspx.cs" Inherits="VerUsuario" %>

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
                <asp:ListBox ID="lst_usuario" runat="server" Height="223px" Width="135px" OnSelectedIndexChanged="lst_usuario_SelectedIndexChanged"></asp:ListBox>
            </td>
            <td style="height: 122px">
                <asp:UpdatePanel ID="UpdateData" runat="server">
                    <ContentTemplate>
                        <table border="0">
                            <tbody>
                                <tr>
                                    <td style="width: 100px" valign="top">
                                        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdateData"></asp:UpdateProgress>
                                        <progresstemplate>
                                             
<TABLE border=0><TBODY><TR><TD style="WIDTH: 13%; HEIGHT: 21px"><asp:Image ID="Image2" runat="server" ImageUrl="~/Imagenes/Loading.gif" Width="40 px" Height="40 px" />
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Actualizando..."></asp:Label></TD></TR></TBODY></TABLE>
</progresstemplate>


                                        <asp:CheckBoxList ID="chkl_roles" runat="server" Height="167px" Width="158px">
                                        </asp:CheckBoxList>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
 
            <td>
                <asp:Button ID="btn_actualizar" runat="server" Text="Actualizar Roles" />
            </td>
        </tr>
    </table>
</asp:Content>
