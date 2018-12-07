<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministrarConsecutivo.aspx.cs" Inherits="VVuelos.AdministrarConsecutivo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label5" runat="server" ForeColor="Red"></asp:Label>
    <p>
        Información del Consecutivo
        <asp:Label ID="Label4" runat="server"></asp:Label>
    </p>

    <table class="nav-justified">
        <tr>
            <td style="height: 22px">Descripción:</td>
            <td style="height: 22px">
                <asp:DropDownList ID="ddl_descripcion" runat="server" DataSourceID="SqlDataSource1" DataTextField="Descripcion" DataValueField="Descripcion">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:V-Vuelos %>" SelectCommand="SELECT [Descripcion] FROM [Consecutivo]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td>Consecutivo:</td>
            <td>
                <asp:TextBox ID="txt_consecutivo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_cons" runat="server" ControlToValidate="txt_consecutivo" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True">Este campo es requerido</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Posee Prefijo:</td>
            <td>
                <asp:CheckBox ID="chk_prefijo" runat="server"/>
            </td>
        </tr>
        <tr>
            <td>Prefijo:</td>
            <td>
                <asp:TextBox ID="txt_prefijo" runat="server"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Posee Rango:</td>
            <td>
                <asp:CheckBox ID="chk_rango" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="height: 20px">Rango inicial:</td>
            <td style="height: 20px">
                <asp:TextBox ID="txt_rango_ini" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Rango final:</td>
            <td>
                <asp:TextBox ID="txt_rango_fin" runat="server"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
                <asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btn_guardar" runat="server" OnClick="btn_guardar_Click" Text="Guardar" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" />
            </td>
        </tr>
    </table>

    <script>
        function validarForm(){	
	        var verificar = true;
	        var expRegNombre=/^[a-zA-ZÑñÁáÉéÍíÓóÚúÜü\s]+$/;
	        var expRegEmail=/^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/;

	        var forumulario = document.getElementById("contacto-frm");
	        var nombre = document.getElementById("nombre");
	        var edad = document.getElementById("edad");
	        var email = document.getElementById("email");
	        var masculino = document.getElementById("masculino");
	        var femenino = document.getElementById("femenino");
	        var asunto = document.getElementById("asunto");
            var comentarios = document.getElementById("comentarios");

    
	        if (!nombre.value){
		        alert("El campo nombre es requerido");
		        nombre.focus();
		        verificar = false;
	        }

	        else if (!expRegNombre.exec(nombre.value)){
		        alert("El campo nombre solo acepta letras y espacios en blanco");
		        nombre.focus();
		        verificar = false;
	        }

	        else if(!edad.value){
		        alert("El campo edad es requerido");
		        edad.focus();
		        verificar = false;
	        }

	        else if (isNaN(edad.value)){
		        alert("El campo edad solo acepta numeros");
		        edad.focus();
		        verificar = false;
	        }

	        else if (edad.value<18 || edad.value>60){
		        alert("La edad debe estar comprendida entre 18 y 60");
		        edad.focus();
		        verificar = false;
	        }

	        else if(!email.value){
		        alert("El campo email es requerido");
		        email.focus();
		        verificar = false;
	        }

	        else if (!expRegEmail.exec(email.value)){
		        alert("El campo email no es válido");
		        email.focus();
		        verificar = false;
	        }

	        else if (!masculino.checked && !femenino.checked){
		        alert("El campo sexo es requerido");
		        masculino.focus();
		        femenino.focus();
		        verificar = false;
	        }

	        else if (!asunto.value){
		        alert("El campo asunto es requerido");
		        asunto.focus();
		        verificar = false;
	        }

	        else if (!comentarios.value){
		        alert("El campo de comentarios es requerido");
		        comentarios.focus();
		        verificar = false;
	        }

	        else if (comentarios.value.length > 255){
		        alert("El campo de comentarios no puede tener mas de 255 caracteres");
		        comentarios.focus();
		        verificar = false;
	        }

	        if (verificar){
		        alert("Se ha enviado el formulario con éxito");
		        document.contacto_frm.submit();
	        }
        }

        function limpiarForm(){
	        alert("Limpiando...");
	        document.getElementById("contacto-frm").reset();
        }

        //window.onload = function(){
	       // var botonEnviar, botonLimpiar;
	       // botonLimpiar = document.getElementById("limpiar");
	       // botonLimpiar.onclick = limpiarForm;

	       // botonLimpiar = document.contacto_frm.enviar_btn;
	       // botonLimpiar.onclick = validarForm;
        //}

        check_prefijo = document.getElementById("MainContent_chk_prefijo");
        input_prefijo = document.getElementById("MainContent_txt_prefijo");
        check_rango = document.getElementById("MainContent_chk_rango");
        input_rango_ini = document.getElementById("MainContent_txt_rango_ini");
        input_rango_fin = document.getElementById("MainContent_txt_rango_fin");
        (check_prefijo.checked) ? $(input_prefijo).show() : $(input_prefijo).hide(); 
        (check_rango.checked) ? $(input_rango_ini).show() : $(input_rango_ini).hide(); 
        (check_rango.checked) ? $(input_rango_fin).show() : $(input_rango_fin).hide(); 
        //input_prefijo.disabled = !(check_prefijo.checked);
        //input_rango_ini.disabled = !(check_rango.checked);
        //input_rango_fin.disabled = !(check_rango.checked);
        check_prefijo.onclick = function () {
            if (check_prefijo.checked) {
                $(input_prefijo).show();
            }
            else {
                $(input_prefijo).hide();
                $(input_prefijo).val("");
            }
            //input_prefijo.disabled = !(check_prefijo.checked);
        }
        check_rango.onclick = function () {
            if (check_rango.checked) {
                $(input_rango_ini).show();                
                $(input_rango_ini).val("");
            }
            else {
                $(input_rango_ini).hide();
                $(input_rango_ini).val("");
            }
            if (check_rango.checked) {
                $(input_rango_fin).show();                
                $(input_rango_fin).val("");
            }
            else {
                $(input_rango_fin).hide();
                $(input_rango_fin).val("");
            }
            //input_rango_ini.disabled = !(check_rango.checked);
            //input_rango_fin.disabled = !(check_rango.checked);
        }
    </script>

</asp:Content>


