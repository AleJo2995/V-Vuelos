﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AdministrarPuertas.aspx.cs" Inherits="VVuelos.AdministrarPuertas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <table class="nav-justified">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="height: 22px">Código:</td>
        <td style="height: 22px">
            <asp:TextBox ID="txt_codigo" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Número:</td>
        <td>
            <asp:TextBox ID="txt_numero" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Tipo:</td>
        <td>
            <asp:TextBox ID="txt_tipo" runat="server"></asp:TextBox>
            <br />
        </td>
    </tr>
        <tr>
        <td>Condición:</td>
        <td>
            <asp:TextBox ID="txt_condicion" runat="server"></asp:TextBox>
        </td>
        </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btn_guardar" runat="server" OnClick="btn_guardar_Click" Text="Guardar" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_cancelar" runat="server" OnClick="btn_cancelar_Click" Text="Cancelar" />
        </td>
    </tr>
</table>

</asp:Content>
