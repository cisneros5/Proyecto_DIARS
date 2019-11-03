using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Licoreria_SLOWLIFE.Models
{
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public string ciudad { get; set; }
        public string fechaIngreso{get;set;}
        public bool estado { get; set; }
        public string usuario { get; set; }
        public string passwd { get; set; }

    }
}