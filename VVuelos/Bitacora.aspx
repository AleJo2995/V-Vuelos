<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Aerolinea.aspx.cs" Inherits="VVuelos.Aerolinea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
    <asp:GridView ID="GV_Bitacora" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_aerolinea" PageSize="5" OnPageIndexChanging="GV_Aerolinea_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="id_aerolinea" HeaderText="ID" />
            <asp:BoundField DataField="nombre" HeaderText="Agencias" />
            <asp:HyperLinkField DataNavigateUrlFields="id_aerolinea" DataNavigateUrlFormatString="DatosAerolinea?cod={0}" Text="Editar" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
    <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" OnClick="btn_nuevo_Click" />
</asp:Content>

