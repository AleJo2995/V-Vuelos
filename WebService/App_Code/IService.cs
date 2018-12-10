using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{

    [OperationContract]

    string devolverTarjeta(int id);

    [OperationContract]

    string devolverEasyPay(int id);

    [OperationContract]

    DataSet cargarTarjeta(string usuario);

    [OperationContract]

    DataSet cargarEasyPay(string usuario);

    [OperationContract]

    void insertarTarjeta(string usuario, int numero, int mes_expiracion, int año_expiracion, int cvv, decimal monto, string emisor, string tipo);

    [OperationContract]

    void insertarEasyPay(string usuario, int numero, int codigo_seguridad, string contraseña, decimal monto);

}