﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministrarPaises.aspx.cs" Inherits="VVuelos.AdministrarPaises" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <table class="nav-justified">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Código_País:</td>
        <td>
            <asp:TextBox ID="txt_codigo_pais" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Nombre:</td>
        <td>
            <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Dirección imágen:</td>
        <td>
            <asp:TextBox ID="txt_direccion_imagen" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btn_guardar" runat="server" OnClick="btn_guardar_Click" Text="Guardar" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_cancelar" runat="server" OnClick="btn_cancelar_Click" Text="Cancelar" />
            <asp:Button ID="btn_cargar" runat="server" OnClick="btn_cargar_Click" Text="Cargar" />
       
            <asp:FileUpload id="FileUploadControl" runat="server" />
    <asp:Label runat="server" id="StatusLabel" text="Upload status: " />    
        </td>
    </tr>
</table>

</asp:Content>