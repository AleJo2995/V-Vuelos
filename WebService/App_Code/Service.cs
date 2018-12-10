using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json;
using WebServiceVVuelos.App_Code;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public class Service : IService
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["V-Vuelos-Pago"].ToString());


    public DataSet cargarTarjeta(string usuario)
    {
        SqlCommand cmd = new SqlCommand("usp_cargar_tarjetas", con);
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Usuario", usuario);
        cmd.Parameters.Clear();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet cargarEasyPay(string usuario)
    {
        SqlCommand cmd = new SqlCommand("usp_cargar_easypay", con);
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Usuario", usuario);
        cmd.Parameters.Clear();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }



    public string devolverTarjeta(int id)
    {
      
        SqlCommand mySqlCommand = con.CreateCommand();
        mySqlCommand.CommandText = "usp_info_tarjeta";
        mySqlCommand.CommandType = CommandType.StoredProcedure;
        mySqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = id;

        SqlDataAdapter SqlDataAdapter = new SqlDataAdapter();
        SqlDataAdapter.SelectCommand = mySqlCommand;
        DataSet ds = new DataSet();
        con.Open();
        SqlDataAdapter.Fill(ds);

        Tarjeta tarjeta = new Tarjeta();

        tarjeta.id = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]); 
        tarjeta.usuario = ds.Tables[0].Rows[0]["Usuario"].ToString(); 
        tarjeta.numero_tarjeta = Convert.ToInt32(ds.Tables[0].Rows[0]["Numero_Tarjeta"]); 
        tarjeta.mes_expiracion = Convert.ToInt32(ds.Tables[0].Rows[0]["Mes_expiracion"]); 
        tarjeta.año_expiracion = Convert.ToInt32(ds.Tables[0].Rows[0]["Año_expiracion"]); 
        tarjeta.cvv = Convert.ToInt32(ds.Tables[0].Rows[0]["CVV"]); ;
        tarjeta.monto = Convert.ToDecimal(ds.Tables[0].Rows[0]["Monto"]); 
        tarjeta.emisor = ds.Tables[0].Rows[0]["Emisor"].ToString(); 
        tarjeta.tipo = ds.Tables[0].Rows[0]["Tipo"].ToString(); 

        return JsonConvert.SerializeObject(tarjeta);
    }

    public string devolverEasyPay(int id)
    {

        SqlCommand mySqlCommand = con.CreateCommand();
        mySqlCommand.CommandText = "usp_info_tarjeta";
        mySqlCommand.CommandType = CommandType.StoredProcedure;
        mySqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = id;

        SqlDataAdapter SqlDataAdapter = new SqlDataAdapter();
        SqlDataAdapter.SelectCommand = mySqlCommand;
        DataSet ds = new DataSet();
        con.Open();
        SqlDataAdapter.Fill(ds);

        EasyPay easypay = new EasyPay();

        easypay.id = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]); 
        easypay.usuario = ds.Tables[0].Rows[0]["Usuario"].ToString();
        easypay.numero_cuenta = Convert.ToInt32(ds.Tables[0].Rows[0]["Numero_cuenta"]); ;
        easypay.codigo_seguridad = Convert.ToInt32(ds.Tables[0].Rows[0]["Codigo_seguridad"]); 
        easypay.contraseña = ds.Tables[0].Rows[0]["Contraseña"].ToString();
        easypay.monto = Convert.ToDecimal(ds.Tables[0].Rows[0]["Monto"]);


        return JsonConvert.SerializeObject(easypay);
    }

    public void insertarTarjeta(string usuario, int numero, int mes_expiracion, int año_expiracion, int cvv, decimal monto, string emisor, string tipo)
    {

        SqlCommand cmd = new SqlCommand("usp_insertar_tarjeta", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@Usuario", usuario);
        cmd.Parameters.AddWithValue("@Numero", numero);
        cmd.Parameters.AddWithValue("@Mes_Expiracion", mes_expiracion);
        cmd.Parameters.AddWithValue("@Year_Expiracion", año_expiracion);
        cmd.Parameters.AddWithValue("@CVV", cvv);
        cmd.Parameters.AddWithValue("@Monto", monto);
        cmd.Parameters.AddWithValue("@Emisor", emisor);
        cmd.Parameters.AddWithValue("@Tipo", tipo);
        cmd.ExecuteNonQuery();

 
    }

    public void insertarEasyPay(string usuario, int numero, int codigo_seguridad, string contraseña, decimal monto)
    {
        SqlCommand cmd = new SqlCommand("usp_insertar_easypay", con);
        cmd.CommandType = CommandType.StoredProcedure;
        con.Open();
        cmd.Parameters.AddWithValue("@Usuario", usuario);
        cmd.Parameters.AddWithValue("@Numero", numero);
        cmd.Parameters.AddWithValue("@Codigo_Seguridad", codigo_seguridad);
        cmd.Parameters.AddWithValue("@Password", contraseña);
        cmd.Parameters.AddWithValue("@Monto", monto);
        cmd.ExecuteNonQuery();

    }


}
