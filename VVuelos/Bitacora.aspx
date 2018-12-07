﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bitacora.aspx.cs" Inherits="VVuelos.Bitacora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
         <asp:GridView ID="GV_Bitacora" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id" PageSize="5" OnPageIndexChanging="GV_Bitacora_PageIndexChanging" AutoGenerateDeleteButton="true">
        <Columns>
            <asp:BoundField DataField="Codigo_registro" HeaderText="Código" />
            <asp:BoundField DataField="Fecha_Hora" HeaderText="Fecha y Hora" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
            <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="DetallesBitacora?cod=0" Text="Detalle" />
        </Columns>
    </asp:GridView>
</asp:Content>

