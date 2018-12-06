﻿using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Web;


namespace BLL
{
    public class Aerolinea
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

        private int _codigo_pais;

        public int codigo_pais
        {
            get { return _codigo_pais; }
            set { _codigo_pais = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _direccion_imagen;

        public string direccion_imagen
        {
            get { return _direccion_imagen; }
            set { _direccion_imagen = value; }
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
        public DataSet carga_aerolineas()
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
                sql = "usp_consulta_aerolineas";
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

        public DataSet carga_aerolineas_por_pais(int ID)
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

                sql = "usp_consulta_aerolineas_por_pais";
                ParamStruct[] parametros = new ParamStruct[1];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ID", SqlDbType.Int, ID);
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


        public void carga_datos_aerolinea(int ID)
        {
            conexion = cls_DAL.trae_conexion("V-Vuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                //insertar en la table de errores
                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
            }
            else
            {
                sql = "usp_info_aerolineas";
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
                        _codigo = Convert.ToInt32(ds.Tables[0].Rows[0]["Codigo"]);
                        _codigo_pais = Convert.ToInt32(ds.Tables[0].Rows[0]["Codigo_Pais"]);
                        _nombre = ds.Tables[0].Rows[0]["Nombre"].ToString();
                        _direccion_imagen = ds.Tables[0].Rows[0]["Direccion_imagen"].ToString();
                       
                    }
                    else
                    {
                        _nombre = "Error";
                        _num_error = numero_error;
                        _mensaje = mensaje_error;
                    }
                }
            }
        }

        public void agregar_aerolinea()
        {
            conexion = cls_DAL.trae_conexion("V-Vuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                //insertar en la table de errores
                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
            
            }
            else
            {
              
                    sql = "usp_inserta_aerolinea";
            
                ParamStruct[] parametros = new ParamStruct[5];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ID_Consecutivo", SqlDbType.Int, _id_consecutivo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Codigo", SqlDbType.Int, _codigo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Codigo_Pais", SqlDbType.Int, _codigo_pais);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Direccion_imagen", SqlDbType.VarChar, _direccion_imagen);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    //insertar en la table de errores
                    HttpContext.Current.Server.Transfer("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                  
                }
                else
                {
                    Bitacora bitacora = new Bitacora();
                    bitacora.usuario = System.Web.HttpContext.Current.User.Identity.Name;
                    bitacora.codigo_registro = 1;
                    bitacora.tipo = "Agregar";
                    bitacora.descripcion = "Se insertó un nuevo elemento en la tabla Aerolínea";
                    bitacora.detalle = "Datos insertados: Consecutivo: " + id_consecutivo + " Código: " + codigo + " Código de País: " + codigo_pais + " Nombre: " + nombre+ " Dirección de imagen: " + direccion_imagen;
                    bitacora.agregar_bitacora();
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    
                }
            }
        }

        public void modifica_aerolinea()
        {
            conexion = cls_DAL.trae_conexion("V-Vuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                //insertar en la table de errores
                HttpContext.Current.Response.Redirect("Error.aspx?error=" + numero_error.ToString() + "&men=" + mensaje_error);
           
            }
            else
            {
                
                    sql = "usp_modifica_aerolinea";
             
                ParamStruct[] parametros = new ParamStruct[6];
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ID", SqlDbType.Int, _id);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@ID_Consecutivo", SqlDbType.Int, _id_consecutivo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Codigo", SqlDbType.Int, _codigo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Codigo_Pais", SqlDbType.Int, _codigo_pais);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Nombre", SqlDbType.VarChar, _nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@Direccion_imagen", SqlDbType.VarChar, _direccion_imagen);
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
                    Bitacora bitacora = new Bitacora();
                    bitacora.usuario = System.Web.HttpContext.Current.User.Identity.Name;
                    bitacora.codigo_registro = 2;
                    bitacora.tipo = "Modificar";
                    bitacora.descripcion = "Se actualizó un elemento en la tabla Aerolínea con ID: "+_id;
                    bitacora.detalle = "Datos insertados: Consecutivo: " + id_consecutivo + " Código: " + codigo + " Código de País: " + codigo_pais + " Nombre: " + nombre + " Dirección de imagen: " + direccion_imagen;
                    bitacora.agregar_bitacora();
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
             
                }
            }
        }

        public bool eliminar_aerolinea(int ID)
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
                sql = "usp_eliminar_aerolinea";
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
                    Bitacora bitacora = new Bitacora();
                    bitacora.usuario = System.Web.HttpContext.Current.User.Identity.Name;
                    bitacora.codigo_registro = 3;
                    bitacora.tipo = "Eliminar";
                    bitacora.descripcion = "Se eliminó un elemento en la tabla Aerolínea";
                    bitacora.detalle = "ID eliminado:"+ID;
                    bitacora.agregar_bitacora();
                    cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                    return true;
                }
            }
        }

        #endregion
    }
}
