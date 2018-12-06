<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ReservacionBoletos.aspx.cs" Inherits="VVuelos.ReservacionBoletos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <asp:DropDownList ID="ddl_metodo_pago" runat="server" DataSourceID="SqlDataSource1" DataTextField="Metodo_pago" DataValueField="Metodo_pago">
                </asp:DropDownList>

     <asp:DropDownList ID="ddl_cuenta" runat="server" DataSourceID="SqlDataSource1" DataTextField="Cuenta" DataValueField="Cuenta">
                </asp:DropDownList>
    
</asp:Content>