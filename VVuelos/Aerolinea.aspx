<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Aerolinea.aspx.cs" Inherits="Aerolinea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
    <asp:GridView ID="GV_Aerolinea" runat="server" AllowPaging="True" AutoGenerateColumns="False" PageSize="5" OnPageIndexChanging="GV_Aerolinea_PageIndexChanging" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
        <AlternatingRowStyle BackColor="Gainsboro" />
        <Columns>
            <asp:BoundField DataField="Codigo" HeaderText="Código" SortExpression="Codigo" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:V-Vuelos %>" SelectCommand="SELECT [Codigo], [Nombre] FROM [Aerolinea]"></asp:SqlDataSource>
    <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
    <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" OnClick="btn_nuevo_Click" />
</asp:Content>
