using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Web;


namespace BLL
{
    public class Puertas_Aeropuerto
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

        private int _aeropuerto;

        public int aeropuerto
        {
            get { return _aeropuerto; }
            set { _aeropuerto = value; }
        }

        private int _codigo_puerta;

        public int codigo_puerta
        {
            get { return _codigo_puerta; }
            set { _codigo_puerta = value; }
        }

        private int _codigo_aerolinea;

        public int codigo_aerolinea
        {
            get { return _codigo_aerolinea; }
            set { _codigo_aerolinea = value; }
        }

        private int _numero_puerta;

        public int numero_puerta
        {
            get { return _numero_puerta; }
            set { _numero_puerta = value; }
        }

        private string _tipo_puerta;

        public string tipo_puerta
        {
            get { return _tipo_puerta; }
            set { _tipo_puerta = value; }
        }

        private string _condicion_puerta;

        public string condicion_puerta
        {
            get { return _condicion_puerta; }
            set { _condicion_puerta = value; }
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
        public DataSet carga_puertas()
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
                sql = "usp_consulta_puertas";
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


        public void datos_puertas(int ID)
        {
            conexion = cls_DAL.trae_conexion("V-Vuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                //insertar en la table de errores
                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
            }
            else
            {
                sql = "usp_info_puerta";
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
                        _id_consecutivo = Convert.ToInt32(ds.Tables[0].Rows[0]["ID_Consecutivo"]);
                        _aeropuerto = Convert.ToInt32(ds.Tables[0].Rows[0]["Aeropuerto"]);
                        _codigo_puerta = Convert.ToInt32(ds.Tables[0].Rows[0]["Codigo_puerta"]);
                        _codigo_aerolinea = Convert.ToInt32(ds.Tables[0].Rows[0]["Codigo_aerolinea"]);
                        _numero_puerta = Convert.ToInt32(ds.Tables[0].Rows[0]["Numero_puerta"]);
                        _tipo_puerta = ds.Tables[0].Rows[0]["Tipo_puerta"].ToString();
                        _condicion_puerta = ds.Tables[0].Rows[0]["Condicion_puerta"].ToString();

                    }
                    else
                    {
                        _tipo_puerta = "Error";
                        _num_error = numero_error;
                        _mensaje = mensaje_error;
                    }
                }
            }
        }

        public void agregar_puertas()
        {
            conexion = cls_DAL.trae_conexion("V-Vuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                //insertar en la table de errores
                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
            
            }
            else
            {
                    sql = "usp_inserta_puerta";
              
              
                ParamStruct[] parametros = new ParamStruct[7];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ID_Consecutivo", SqlDbType.Int, _id_consecutivo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Aeropuerto", SqlDbType.Int, _aeropuerto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Codigo_puerta", SqlDbType.Int, _codigo_puerta);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Codigo_aerolinea", SqlDbType.Int, _codigo_aerolinea);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Numero_puerta", SqlDbType.Int, _numero_puerta);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@Tipo_puerta", SqlDbType.VarChar, _tipo_puerta);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@Condicion_puerta", SqlDbType.VarChar, _condicion_puerta);
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


        public void modifica_puertas()
        {
            conexion = cls_DAL.trae_conexion("V-Vuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                //insertar en la table de errores
                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
            
            }
            else
            {
                    sql = "usp_modifica_puerta";
               
                ParamStruct[] parametros = new ParamStruct[8];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ID", SqlDbType.Int, _id);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@ID_Consecutivo", SqlDbType.Int, _id_consecutivo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Aeropuerto", SqlDbType.Int, _aeropuerto);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Codigo_puerta", SqlDbType.Int, _codigo_puerta);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Codigo_aerolinea", SqlDbType.Int, _codigo_aerolinea);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@Numero_puerta", SqlDbType.Int, _numero_puerta);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@Tipo_puerta", SqlDbType.VarChar, _tipo_puerta);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@Condicion_puerta", SqlDbType.VarChar, _condicion_puerta);
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

        public bool eliminar_puertas(int ID)
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
                sql = "usp_eliminar_puertas";
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
