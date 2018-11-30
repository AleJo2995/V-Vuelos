<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consecutivo.aspx.cs" Inherits="VVuelos.Consecutivo" %>
<asp:Content ID="Consecutivo" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
       <asp:GridView ID="MC_Consecutivo" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_consecutivo" PageSize="5" OnPageIndexChanging="MC_Consecutivo_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
            <asp:BoundField DataField="consecutivo" HeaderText="Consecutivo" />
            <asp:HyperLinkField DataNavigateUrlFields="id_consecutivo" DataNavigateUrlFormatString="DatosConsecutivo?cod={0}" Text="Editar" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:V-Vuelos %>" SelectCommand="SELECT [ID], [DESCRIPCION], [NOMBRE] FROM [Aerolinea]"></asp:SqlDataSource>
    <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
    <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" OnClick="btn_nuevo_Click" />
</asp:Content>
