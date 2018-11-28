<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Aerolinea.aspx.cs" Inherits="VVuelos.Aerolinea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
    <asp:GridView ID="GV_Aerolinea" runat="server" AllowPaging="True" AutoGenerateColumns="False" PageSize="5" OnPageIndexChanging="GV_Aerolinea_PageIndexChanging" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:V-Vuelos %>" SelectCommand="SELECT [Codigo], [Nombre] FROM [Aerolinea]"></asp:SqlDataSource>
    <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
    <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" OnClick="btn_nuevo_Click" />
</asp:Content>
