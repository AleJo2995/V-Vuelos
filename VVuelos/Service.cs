﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data;



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IService")]
public interface IService
{
    
    // CODEGEN: El parámetro 'devolverTarjetaResult' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/devolverTarjeta", ReplyAction="http://tempuri.org/IService/devolverTarjetaResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    devolverTarjetaResponse devolverTarjeta(devolverTarjetaRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/devolverTarjeta", ReplyAction="http://tempuri.org/IService/devolverTarjetaResponse")]
    System.Threading.Tasks.Task<devolverTarjetaResponse> devolverTarjetaAsync(devolverTarjetaRequest request);
    
    // CODEGEN: El parámetro 'devolverEasyPayResult' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/devolverEasyPay", ReplyAction="http://tempuri.org/IService/devolverEasyPayResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    devolverEasyPayResponse devolverEasyPay(devolverEasyPayRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/devolverEasyPay", ReplyAction="http://tempuri.org/IService/devolverEasyPayResponse")]
    System.Threading.Tasks.Task<devolverEasyPayResponse> devolverEasyPayAsync(devolverEasyPayRequest request);
    
    // CODEGEN: El parámetro 'cargarTarjetaResult' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/cargarTarjeta", ReplyAction="http://tempuri.org/IService/cargarTarjetaResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    cargarTarjetaResponse cargarTarjeta(cargarTarjetaRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/cargarTarjeta", ReplyAction="http://tempuri.org/IService/cargarTarjetaResponse")]
    System.Threading.Tasks.Task<cargarTarjetaResponse> cargarTarjetaAsync(cargarTarjetaRequest request);
    
    // CODEGEN: El parámetro 'cargarEasyPayResult' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/cargarEasyPay", ReplyAction="http://tempuri.org/IService/cargarEasyPayResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    cargarEasyPayResponse cargarEasyPay(cargarEasyPayRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/cargarEasyPay", ReplyAction="http://tempuri.org/IService/cargarEasyPayResponse")]
    System.Threading.Tasks.Task<cargarEasyPayResponse> cargarEasyPayAsync(cargarEasyPayRequest request);
    
    // CODEGEN: El parámetro 'usuario' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/insertarTarjeta", ReplyAction="http://tempuri.org/IService/insertarTarjetaResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    insertarTarjetaResponse insertarTarjeta(insertarTarjetaRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/insertarTarjeta", ReplyAction="http://tempuri.org/IService/insertarTarjetaResponse")]
    System.Threading.Tasks.Task<insertarTarjetaResponse> insertarTarjetaAsync(insertarTarjetaRequest request);
    
    // CODEGEN: El parámetro 'usuario' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/insertarEasyPay", ReplyAction="http://tempuri.org/IService/insertarEasyPayResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    insertarEasyPayResponse insertarEasyPay(insertarEasyPayRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/insertarEasyPay", ReplyAction="http://tempuri.org/IService/insertarEasyPayResponse")]
    System.Threading.Tasks.Task<insertarEasyPayResponse> insertarEasyPayAsync(insertarEasyPayRequest request);
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="devolverTarjeta", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class devolverTarjetaRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    public int id;
    
    public devolverTarjetaRequest()
    {
    }
    
    public devolverTarjetaRequest(int id)
    {
        this.id = id;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="devolverTarjetaResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class devolverTarjetaResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string devolverTarjetaResult;
    
    public devolverTarjetaResponse()
    {
    }
    
    public devolverTarjetaResponse(string devolverTarjetaResult)
    {
        this.devolverTarjetaResult = devolverTarjetaResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="devolverEasyPay", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class devolverEasyPayRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    public int id;
    
    public devolverEasyPayRequest()
    {
    }
    
    public devolverEasyPayRequest(int id)
    {
        this.id = id;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="devolverEasyPayResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class devolverEasyPayResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string devolverEasyPayResult;
    
    public devolverEasyPayResponse()
    {
    }
    
    public devolverEasyPayResponse(string devolverEasyPayResult)
    {
        this.devolverEasyPayResult = devolverEasyPayResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="cargarTarjeta", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class cargarTarjetaRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string usuario;
    
    public cargarTarjetaRequest()
    {
    }
    
    public cargarTarjetaRequest(string usuario)
    {
        this.usuario = usuario;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="cargarTarjetaResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class cargarTarjetaResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public System.Data.DataSet cargarTarjetaResult;
    
    public cargarTarjetaResponse()
    {
    }
    
    public cargarTarjetaResponse(System.Data.DataSet cargarTarjetaResult)
    {
        this.cargarTarjetaResult = cargarTarjetaResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="cargarEasyPay", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class cargarEasyPayRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string usuario;
    
    public cargarEasyPayRequest()
    {
    }
    
    public cargarEasyPayRequest(string usuario)
    {
        this.usuario = usuario;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="cargarEasyPayResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class cargarEasyPayResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public System.Data.DataSet cargarEasyPayResult;
    
    public cargarEasyPayResponse()
    {
    }
    
    public cargarEasyPayResponse(System.Data.DataSet cargarEasyPayResult)
    {
        this.cargarEasyPayResult = cargarEasyPayResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="insertarTarjeta", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class insertarTarjetaRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string usuario;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
    public int numero;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
    public int mes_expiracion;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
    public int año_expiracion;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
    public int cvv;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
    public decimal monto;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string emisor;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=7)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string tipo;
    
    public insertarTarjetaRequest()
    {
    }
    
    public insertarTarjetaRequest(string usuario, int numero, int mes_expiracion, int año_expiracion, int cvv, decimal monto, string emisor, string tipo)
    {
        this.usuario = usuario;
        this.numero = numero;
        this.mes_expiracion = mes_expiracion;
        this.año_expiracion = año_expiracion;
        this.cvv = cvv;
        this.monto = monto;
        this.emisor = emisor;
        this.tipo = tipo;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="insertarTarjetaResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class insertarTarjetaResponse
{
    
    public insertarTarjetaResponse()
    {
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="insertarEasyPay", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class insertarEasyPayRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string usuario;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
    public int numero;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
    public int codigo_seguridad;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string contraseña;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
    public decimal monto;
    
    public insertarEasyPayRequest()
    {
    }
    
    public insertarEasyPayRequest(string usuario, int numero, int codigo_seguridad, string contraseña, decimal monto)
    {
        this.usuario = usuario;
        this.numero = numero;
        this.codigo_seguridad = codigo_seguridad;
        this.contraseña = contraseña;
        this.monto = monto;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="insertarEasyPayResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class insertarEasyPayResponse
{
    
    public insertarEasyPayResponse()
    {
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServiceChannel : IService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class ServiceClient : System.ServiceModel.ClientBase<IService>, IService
{
    
    public ServiceClient()
    {
    }
    
    public ServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    devolverTarjetaResponse IService.devolverTarjeta(devolverTarjetaRequest request)
    {
        return base.Channel.devolverTarjeta(request);
    }
    
    public string devolverTarjeta(int id)
    {
        devolverTarjetaRequest inValue = new devolverTarjetaRequest();
        inValue.id = id;
        devolverTarjetaResponse retVal = ((IService)(this)).devolverTarjeta(inValue);
        return retVal.devolverTarjetaResult;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<devolverTarjetaResponse> IService.devolverTarjetaAsync(devolverTarjetaRequest request)
    {
        return base.Channel.devolverTarjetaAsync(request);
    }
    
    public System.Threading.Tasks.Task<devolverTarjetaResponse> devolverTarjetaAsync(int id)
    {
        devolverTarjetaRequest inValue = new devolverTarjetaRequest();
        inValue.id = id;
        return ((IService)(this)).devolverTarjetaAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    devolverEasyPayResponse IService.devolverEasyPay(devolverEasyPayRequest request)
    {
        return base.Channel.devolverEasyPay(request);
    }
    
    public string devolverEasyPay(int id)
    {
        devolverEasyPayRequest inValue = new devolverEasyPayRequest();
        inValue.id = id;
        devolverEasyPayResponse retVal = ((IService)(this)).devolverEasyPay(inValue);
        return retVal.devolverEasyPayResult;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<devolverEasyPayResponse> IService.devolverEasyPayAsync(devolverEasyPayRequest request)
    {
        return base.Channel.devolverEasyPayAsync(request);
    }
    
    public System.Threading.Tasks.Task<devolverEasyPayResponse> devolverEasyPayAsync(int id)
    {
        devolverEasyPayRequest inValue = new devolverEasyPayRequest();
        inValue.id = id;
        return ((IService)(this)).devolverEasyPayAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    cargarTarjetaResponse IService.cargarTarjeta(cargarTarjetaRequest request)
    {
        return base.Channel.cargarTarjeta(request);
    }
    
    public System.Data.DataSet cargarTarjeta(string usuario)
    {
        cargarTarjetaRequest inValue = new cargarTarjetaRequest();
        inValue.usuario = usuario;
        cargarTarjetaResponse retVal = ((IService)(this)).cargarTarjeta(inValue);
        return retVal.cargarTarjetaResult;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<cargarTarjetaResponse> IService.cargarTarjetaAsync(cargarTarjetaRequest request)
    {
        return base.Channel.cargarTarjetaAsync(request);
    }
    
    public System.Threading.Tasks.Task<cargarTarjetaResponse> cargarTarjetaAsync(string usuario)
    {
        cargarTarjetaRequest inValue = new cargarTarjetaRequest();
        inValue.usuario = usuario;
        return ((IService)(this)).cargarTarjetaAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    cargarEasyPayResponse IService.cargarEasyPay(cargarEasyPayRequest request)
    {
        return base.Channel.cargarEasyPay(request);
    }
    
    public System.Data.DataSet cargarEasyPay(string usuario)
    {
        cargarEasyPayRequest inValue = new cargarEasyPayRequest();
        inValue.usuario = usuario;
        cargarEasyPayResponse retVal = ((IService)(this)).cargarEasyPay(inValue);
        return retVal.cargarEasyPayResult;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<cargarEasyPayResponse> IService.cargarEasyPayAsync(cargarEasyPayRequest request)
    {
        return base.Channel.cargarEasyPayAsync(request);
    }
    
    public System.Threading.Tasks.Task<cargarEasyPayResponse> cargarEasyPayAsync(string usuario)
    {
        cargarEasyPayRequest inValue = new cargarEasyPayRequest();
        inValue.usuario = usuario;
        return ((IService)(this)).cargarEasyPayAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    insertarTarjetaResponse IService.insertarTarjeta(insertarTarjetaRequest request)
    {
        return base.Channel.insertarTarjeta(request);
    }
    
    public void insertarTarjeta(string usuario, int numero, int mes_expiracion, int año_expiracion, int cvv, decimal monto, string emisor, string tipo)
    {
        insertarTarjetaRequest inValue = new insertarTarjetaRequest();
        inValue.usuario = usuario;
        inValue.numero = numero;
        inValue.mes_expiracion = mes_expiracion;
        inValue.año_expiracion = año_expiracion;
        inValue.cvv = cvv;
        inValue.monto = monto;
        inValue.emisor = emisor;
        inValue.tipo = tipo;
        insertarTarjetaResponse retVal = ((IService)(this)).insertarTarjeta(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<insertarTarjetaResponse> IService.insertarTarjetaAsync(insertarTarjetaRequest request)
    {
        return base.Channel.insertarTarjetaAsync(request);
    }
    
    public System.Threading.Tasks.Task<insertarTarjetaResponse> insertarTarjetaAsync(string usuario, int numero, int mes_expiracion, int año_expiracion, int cvv, decimal monto, string emisor, string tipo)
    {
        insertarTarjetaRequest inValue = new insertarTarjetaRequest();
        inValue.usuario = usuario;
        inValue.numero = numero;
        inValue.mes_expiracion = mes_expiracion;
        inValue.año_expiracion = año_expiracion;
        inValue.cvv = cvv;
        inValue.monto = monto;
        inValue.emisor = emisor;
        inValue.tipo = tipo;
        return ((IService)(this)).insertarTarjetaAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    insertarEasyPayResponse IService.insertarEasyPay(insertarEasyPayRequest request)
    {
        return base.Channel.insertarEasyPay(request);
    }
    
    public void insertarEasyPay(string usuario, int numero, int codigo_seguridad, string contraseña, decimal monto)
    {
        insertarEasyPayRequest inValue = new insertarEasyPayRequest();
        inValue.usuario = usuario;
        inValue.numero = numero;
        inValue.codigo_seguridad = codigo_seguridad;
        inValue.contraseña = contraseña;
        inValue.monto = monto;
        insertarEasyPayResponse retVal = ((IService)(this)).insertarEasyPay(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<insertarEasyPayResponse> IService.insertarEasyPayAsync(insertarEasyPayRequest request)
    {
        return base.Channel.insertarEasyPayAsync(request);
    }
    
    public System.Threading.Tasks.Task<insertarEasyPayResponse> insertarEasyPayAsync(string usuario, int numero, int codigo_seguridad, string contraseña, decimal monto)
    {
        insertarEasyPayRequest inValue = new insertarEasyPayRequest();
        inValue.usuario = usuario;
        inValue.numero = numero;
        inValue.codigo_seguridad = codigo_seguridad;
        inValue.contraseña = contraseña;
        inValue.monto = monto;
        return ((IService)(this)).insertarEasyPayAsync(inValue);
    }
}
