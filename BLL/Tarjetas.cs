using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Web;


namespace BLL
{
    public class Tarjetas
    {
        #region propiedades

        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _numero_tarjeta;

        public int numero_tarjeta
        {
            get { return _numero_tarjeta; }
            set { _numero_tarjeta = value; }
        }

        private int _mes_expiracion;

        public int mes_expiracion
        {
            get { return _mes_expiracion; }
            set { _mes_expiracion = value; }
        }

        private int _año_expiracion;

        public int año_expiracion
        {
            get { return _año_expiracion; }
            set { _año_expiracion = value; }
        }

        private int _cvv;

        public int cvv
        {
            get { return _cvv; }
            set { _cvv = value; }
        }

        private decimal _monto;

        public decimal monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        private string _tipo;

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
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
        public DataSet carga_lista_tarjetas()
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
                sql = "usp_lista_paises";
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


        
   
        #endregion
    }
}