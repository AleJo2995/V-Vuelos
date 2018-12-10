<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdquisicionBoletos.aspx.cs" Inherits="VVuelos.AdquisicionBoletos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="nav-justified">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>

            <br />

     <tr>

        <td>Número Vuelo:</td>
        <td>

            <asp:DropDownList ID="ddl_destino" runat="server" DataTextField="codigo" >
                </asp:DropDownList>
                <asp:Button ID="btn_select" runat="server" OnClick="btn_select_Click" Text="Seleccionar viaje" />
      
            </td>
    </tr>

             <td>Cantidad de boletos a adquirir:<br />
       </td>
            &nbsp;<td><asp:TextBox ID="txt_boletos" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_boletos" runat="server" ControlToValidate="txt_boletos" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True">Este campo es requerido</asp:RequiredFieldValidator>
            

                <asp:Label ID="lbl_precio_string" runat="server" ForeColor="Red"></asp:Label>
             <asp:Label ID="lbl_precio" runat="server" ForeColor="Red"></asp:Label>
                <asp:Label ID="lbl_cantidad_string" runat="server" ForeColor="Red"></asp:Label>
              <asp:Label ID="lbl_cantidad" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>

        <asp:Button ID="btn_pago_tarjeta" runat="server" OnClick="btn_pago_tarjeta_Click" Text="Pago Tarjeta" />
           &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_pago_easy_pay" runat="server" OnClick="btn_pago_easy_pay_Click" Text="Pago Easy Pay" />
           &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_reservacion" runat="server" OnClick="btn_reservacion_Click" Text="Reservar boletos" />
           &nbsp;&nbsp;&nbsp;
          <asp:Button ID="btn_cancelar" runat="server" OnClick="btn_cancelar_Click" Text="Cancelar" />

    </tr>
 
       

             <asp:Label ID="lbl_mensaje" runat="server" ForeColor="Red"></asp:Label>
             &nbsp;&nbsp;&nbsp;

         
    
          

    
   
</table>

</asp:Content>


