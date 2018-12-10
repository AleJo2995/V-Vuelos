using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceVVuelos.App_Code
{
    public class EasyPay
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public int numero_cuenta { get; set; }
        public int codigo_seguridad { get; set; }
        public string contraseña { get; set; }
        public decimal monto { get; set; }
    }
}