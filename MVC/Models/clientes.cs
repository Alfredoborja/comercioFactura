using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class clientes
    {
        public int ID { get; set; }
        public string cliente { get; set; }
        public string tax_id { get; set; }
        public string calle { get; set; }
        public string cp { get; set; }
        public string colonia { get; set; }
        public string entidad { get; set; }
        public string pais { get; set; }
        public string country_code { get; set;}
        public string incoterm { get; set; }
        public decimal tipo_cambio { get; set; }
        public string moneda { get; set; }

    }

    public class clientesXBusqueda 
    {
        public int ID { get; set; }
        public string cliente { get; set; }
        public string tax_id { get; set; }
        public string calle { get; set; }
        public string cp { get; set; }
        public string colonia { get; set; }
        public string entidad { get; set; }
        public string pais { get; set; }
        public string country_code { get; set; }
        public string incoterm { get; set; }
        public decimal tipo_cambio { get; set; }
        public string moneda { get; set; }
    }
}