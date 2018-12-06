<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdquisicionBoletos.aspx.cs" Inherits="VVuelos.AdquisicionBoletos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <asp:DropDownList ID="ddl_destino" runat="server" DataSourceID="SqlDataSource1" DataTextField="Destino" DataValueField="Destino">
                </asp:DropDownList>

       <br />

     <tr>
            <td>Cantidad de boletos a adquirir:<br />
       </td>
            &nbsp;<td><asp:TextBox ID="txt_boletos" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_boletos" runat="server" ControlToValidate="txt_boletos" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True">Este campo es requerido</asp:RequiredFieldValidator>
            </td>
        </tr>

    <asp:Button ID="btn_reservacion" runat="server" OnClick="btn_reservacion_Click" Text="Reservar boletos" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_compra" runat="server" OnClick="btn_comprar_Click" Text="Comprar boletos" />
    &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" />


</asp:Content>


