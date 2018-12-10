using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceVVuelos.App_Code
{
    public class Tarjeta
    {

        public int id { get; set; }
        public string usuario { get;  set; }
        public int numero_tarjeta { get; set; }
        public int mes_expiracion { get; set; }
        public int año_expiracion { get; set; }
        public int cvv { get; set; }
        public decimal monto { get; set; }
        public string emisor { get; set; }
        public string tipo { get; set; }

    }
}