<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministrarConsecutivo.aspx.cs" Inherits="VVuelos.AdministrarConsecutivo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label5" runat="server" ForeColor="Red"></asp:Label>
    <p>
        Información del Consecutivo
        <asp:Label ID="Label4" runat="server"></asp:Label>
    </p>
      


    <table class="nav-justified">
        <tr>
            <td style="height: 22px">Descripción:</td>
            <td style="height: 22px">
                    <asp:DropDownList ID="ddl_descripcion" runat="server" DataTextField="Descripcion" DataValueField="Descripcion">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Consecutivo:</td>
            <td>
                <asp:TextBox ID="txt_consecutivo" runat="server" MaxLength="5"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_cons" runat="server" ControlToValidate="txt_consecutivo" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True">Este campo es requerido</asp:RequiredFieldValidator>
      
            </td>
        </tr>
        <tr>
            <td>Posee Prefijo:</td>
            <td>
                <asp:CheckBox ID="chk_prefijo" runat="server"/>
            </td>
        </tr>
        <tr>
            <td>Prefijo:</td>
            <td>
                <asp:TextBox ID="txt_prefijo" MaxLength="5" runat="server"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Posee Rango:</td>
            <td>
                <asp:CheckBox ID="chk_rango" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="height: 20px">Rango inicial:</td>
            <td style="height: 20px">
                <asp:TextBox ID="txt_rango_ini" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Rango final:</td>
            <td>
                <asp:TextBox ID="txt_rango_fin" runat="server"></asp:TextBox>
                <asp:Label ID="lbl_rango" runat="server" ForeColor="Black"></asp:Label>
                <asp:Label ID="Label2" runat="server" ForeColor="Black"></asp:Label>
                <asp:Label ID="Label3" runat="server" ForeColor="Black"></asp:Label>
                <asp:Label ID="lbl_mensaje" runat="server" ForeColor="Black"></asp:Label>
             &nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btn_guardar" runat="server" OnClick="btn_guardar_Click" Text="Guardar" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" />
            
            </td>
        </tr>
    </table>

    

</asp:Content>


