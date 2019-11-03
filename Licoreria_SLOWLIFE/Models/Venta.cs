using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Licoreria_SLOWLIFE.Models
{
    public class Venta
    {
        public int idVenta { get; set; }
        public string fecha { get; set; }
        public string nota { get; set; }
        public bool estado { get; set; }

    }
}