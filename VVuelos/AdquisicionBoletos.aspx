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

            <asp:DropDownList ID="ddl_destino" runat="server" >
                </asp:DropDownList>

      
            </td>
    </tr>

             <td>Cantidad de boletos a adquirir:<br />
       </td>
            &nbsp;<td><asp:TextBox ID="txt_boletos" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_boletos" runat="server" ControlToValidate="txt_boletos" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True">Este campo es requerido</asp:RequiredFieldValidator>
            </td>
        </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>

          <asp:Button ID="btn_cancelar" runat="server" OnClick="btn_cancelar_Click" Text="Cancelar" />

    </tr>
 
       

             <asp:Label ID="lbl_mensaje" runat="server" ForeColor="Red"></asp:Label>
             &nbsp;&nbsp;&nbsp;

         
    
          

    
   
</table>

</asp:Content>


