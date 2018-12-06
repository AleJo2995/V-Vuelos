
<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Puertas.aspx.cs" Inherits="VVuelos.Puertas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <asp:GridView ID="MC_Puertas" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_consecutivo" PageSize="5" OnPageIndexChanging="MC_Puertas_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="codigo_puerta" HeaderText="Código" />
            <asp:BoundField DataField="numero_puerta" HeaderText="Número" />
            <asp:BoundField DataField="tipo_puerta" HeaderText="Tipo" />
            <asp:BoundField DataField="condicion_puerta" HeaderText="Condición" />
            <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="AdministrarPuertas?cod={0}" Text="Editar" />
        </Columns>
    </asp:GridView>

        <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
    <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" OnClick="btn_nuevo_Click" />


   

</asp:Content>