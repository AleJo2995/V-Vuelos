<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AerolineaPorPais.aspx.cs" Inherits="VVuelos.AerolineaPorPais" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
     <asp:DropDownList ID="ddl_codigo" runat="server" DataSourceID="SqlDataSource1" DataTextField="Codigo" DataValueField="Codigo">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:V-Vuelos %>" SelectCommand="SELECT [Codigo] FROM [Pais]"></asp:SqlDataSource>

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
    <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
    
     <asp:Button ID="btn_buscar" runat="server" OnClick="btn_buscar_Click" Text="Buscar" />
         
    </asp:Content>
