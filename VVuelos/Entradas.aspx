<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Entradas.aspx.cs" Inherits="VVuelos.Entradas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <meta http-equiv="Refresh" content="10;URL=Salidas.aspx";>
   <body onload="window.SetTimeout('window.Location.Reload()',5000);">
        <asp:GridView ID="GV_Entradas" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" PageSize="10" OnPageIndexChanging="MC_Salidas_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="codigo" HeaderText="Vuelo" />
            <asp:BoundField DataField="aerolinea" HeaderText="Aerolinea" />
            <asp:BoundField DataField="procedencia" HeaderText="Procedencia" />
            <asp:BoundField DataField="fecha" HeaderText="Fecha" />
            <asp:BoundField DataField="hora" HeaderText="Hora" />
            <asp:BoundField DataField="estado" HeaderText="Estado" />
            <asp:BoundField DataField="puerta" HeaderText="Puerta" />
        </Columns>
    </asp:GridView>
    
     
    


</asp:Content>



