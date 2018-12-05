<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paises.aspx.cs" Inherits="VVuelos.Paises" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
       <asp:GridView ID="MC_Paises" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_consecutivo" PageSize="5" OnPageIndexChanging="MC_Paises_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="codigo" HeaderText="Código" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:HyperLinkField DataNavigateUrlFields="codigo" DataNavigateUrlFormatString="AdministrarPaises?cod={0}" Text="Editar" />
        </Columns>
    </asp:GridView>
    




    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:V-Vuelos %>" SelectCommand="SELECT [ID], [CODIGO], [NOMBRE] FROM [Pais]"></asp:SqlDataSource>
    <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
    <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" OnClick="btn_nuevo_Click" />

 

</asp:Content>



