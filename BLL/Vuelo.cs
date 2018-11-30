using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Web;


namespace BLL
{
    public class Vuelo
    {
        #region propiedades

        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _id_consecutivo;

        public int id_consecutivo
        {
            get { return _id_consecutivo; }
            set { _id_consecutivo = value; }
        }

        private int _codigo;

        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _tipo;

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private int _aerolinea;

        public int aerolinea
        {
            get { return _aerolinea; }
            set { _aerolinea = value; }
        }


        private int _aeropuerto;

        public int aeropuerto
        {
            get { return _aeropuerto; }
            set { _aeropuerto = value; }
        }

        private string _procedencia;

        public string procedencia
        {
            get { return _procedencia; }
            set { _procedencia = value; }
        }

        private string _destino;

        public string destino
        {
            get { return _destino; }
            set { _destino = value; }
        }

        private string _fecha;

        public string fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private string _hora;

        public string hora
        {
            get { return _hora; }
            set { _hora = value; }
        }

        private string _estado;

        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private int _numero_boletos;

        public int numero_boletos
        {
            get { return _numero_boletos; }
            set { _numero_boletos = value; }
        }

        private string _precio;

        public string precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private string _mensaje;

        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        private int _num_error;

        public int num_error
        {
            get { return _num_error; }
            set { _num_error = value; }
        }
        #endregion

        #region variables privadas
        SqlConnection conexion;
        string mensaje_error;
        int numero_error;
        string sql;
        DataSet ds;
        #endregion

        #region metodos
        public DataSet carga_vuelos()
        {
            conexion = cls_DAL.trae_conexion("V-Vuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                //insertar en la table de errores
                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                return null;
            }
            else
            {
                sql = "usp_consulta_vuelos";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    //insertar en la table de errores
                    HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                    return null;
                }
                else
                {
                    return ds;
                }
            }

        }


        public void datos_vuelos(int ID)
        {
            conexion = cls_DAL.trae_conexion("V-Vuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                //insertar en la table de errores
                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
            }
            else
            {
                sql = "usp_info_vuelos";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ID", SqlDbType.Int, ID);
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    //insertar en la table de errores
                    HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                }
                else
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        _id = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
                        _id_consecutivo = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_consecutivo"]);
                        _codigo = Convert.ToInt32(ds.Tables[0].Rows[0]["Codigo"]);
                        _tipo = ds.Tables[0].Rows[0]["Tipo"].ToString();
                        _aerolinea = Convert.ToInt32(ds.Tables[0].Rows[0]["Aerolinea"]);
                        _aeropuerto = Convert.ToInt32(ds.Tables[0].Rows[0]["Aeropuerto"]);
                        _procedencia = ds.Tables[0].Rows[0]["Procedencia"].ToString();
                        _destino = ds.Tables[0].Rows[0]["Destino"].ToString();
                        _fecha = ds.Tables[0].Rows[0]["Fecha"].ToString();
                        _hora = ds.Tables[0].Rows[0]["Hora"].ToString();
                        _estado = ds.Tables[0].Rows[0]["Estado"].ToString();
                        _numero_boletos = Convert.ToInt32(ds.Tables[0].Rows[0]["Numero_boletos"]);
                        _precio = ds.Tables[0].Rows[0]["Precio"].ToString();
                    }
                    else
                    {

                        _num_error = numero_error;
                        _mensaje = mensaje_error;
                    }
                }
            }
        }

        public void agregar_vuelos()
        {
            conexion = cls_DAL.trae_conexion("V-Vuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                //insertar en la table de errores
                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
              
            }
            else
            {
               
                    sql = "usp_inserta_vuelo";
           
                ParamStruct[] parametros = new ParamStruct[12];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ID_consecutivo", SqlDbType.Int, _id_consecutivo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Codigo", SqlDbType.Int, _codigo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Tipo", SqlDbType.VarChar, _tipo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Aerolinea", SqlDbType.Int, _aerolinea);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Aeropuerto", SqlDbType.Int, _aeropuerto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@Procedencia", SqlDbType.VarChar, _procedencia);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@Destino", SqlDbType.VarChar, _destino);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@Fecha", SqlDbType.Date, _fecha);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@Hora", SqlDbType.Time, _hora);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@Estado", SqlDbType.VarChar, _estado);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 10, "@Numero_boletos", SqlDbType.Int, _numero_boletos);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 11, "@Precio", SqlDbType.VarChar, _precio);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    //insertar en la table de errores
                    HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                  
                }
                else
                {
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                  
                }
            }
        }

        public void modifica_vuelos()
        {
            conexion = cls_DAL.trae_conexion("V-Vuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                //insertar en la table de errores
                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
             
            }
            else
            {
                    sql = "usp_modifica_vuelo";
              
                ParamStruct[] parametros = new ParamStruct[13];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ID", SqlDbType.Int, _id);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@ID_consecutivo", SqlDbType.Int, _id_consecutivo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Codigo", SqlDbType.Int, _codigo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Tipo", SqlDbType.VarChar, _tipo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Aerolinea", SqlDbType.Int, _aerolinea);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@Aeropuerto", SqlDbType.Int, _aeropuerto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@Procedencia", SqlDbType.VarChar, _procedencia);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@Destino", SqlDbType.VarChar, _destino);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@Fecha", SqlDbType.Date, _fecha);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 9, "@Hora", SqlDbType.Time, _hora);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 10, "@Estado", SqlDbType.VarChar, _estado);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 11, "@Numero_boletos", SqlDbType.Int, _numero_boletos);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 12, "@Precio", SqlDbType.VarChar, _precio);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    //insertar en la table de errores
                    HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
         
                }
                else
                {
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                 
                }
            }
        }

        public bool eliminar_vuelos(int ID)
        {
            conexion = cls_DAL.trae_conexion("V-Vuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                //insertar en la table de errores
                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                return false;
            }
            else
            {
                sql = "usp_eliminar_vuelos";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ID", SqlDbType.Int, ID);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    //insertar en la table de errores
                    HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return false;
                }
                else
                {
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return true;
                }
            }
        }
        #endregion
    }
}