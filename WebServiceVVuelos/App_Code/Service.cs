using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json;
using WebServiceVVuelos.App_Code;

public class Service : IService
{
    public string devolverTarjeta(int id, string usuario, int numero, int mes_expiracion, int año_expiracion, int cvv, decimal monto, string emisor, string tipo)
    {
        Tarjeta tarjeta = new Tarjeta();

        tarjeta.id = id;
        tarjeta.usuario = usuario;
        tarjeta.numero_tarjeta = numero;
        tarjeta.mes_expiracion = mes_expiracion;
        tarjeta.año_expiracion = año_expiracion;
        tarjeta.cvv = cvv;
        tarjeta.monto = monto;
        tarjeta.emisor = emisor;
        tarjeta.tipo = tipo;

        return JsonConvert.SerializeObject(tarjeta);
    }

    public string devolverEasyPay(int id, string usuario, int numero, int codigo_seguridad, string contraseña, decimal monto)
    {
        EasyPay easypay = new EasyPay();

        easypay.id = id;
        easypay.usuario = usuario;
        easypay.numero_cuenta = numero;
        easypay.codigo_seguridad = codigo_seguridad;
        easypay.contraseña = contraseña;
        easypay.monto = monto;
      

        return JsonConvert.SerializeObject(easypay);
    }
}
