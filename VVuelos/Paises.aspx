﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paises.aspx.cs" Inherits="VVuelos.Paises" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
       <asp:GridView ID="MC_Paises" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_consecutivo" PageSize="5" OnPageIndexChanging="MC_Paises_PageIndexChanging" AutoGenerateDeleteButton="False" EditRowStyle-Wrap="False">
        <Columns>
            <asp:BoundField DataField="codigo" HeaderText="Código" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:ImageField DataImageUrlField="Direccion_imagen" ControlStyle-Height="50 px" ControlStyle-Width="50 px"></asp:ImageField>
            <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="AdministrarPaises?cod={0}" Text="Editar" />
        </Columns>
    </asp:GridView>
    
    <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
    <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" OnClick="btn_nuevo_Click" />

 

</asp:Content>


