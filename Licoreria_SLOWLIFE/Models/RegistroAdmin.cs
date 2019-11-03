using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Licoreria_SLOWLIFE.Models
{
    public class RegistroAdmin
    {
        public int idRegistroAdmin { get; set; }
        public string accion { get; set; }


        public Admin admin { get; set; }
        public int idAdmin { get; set; }
    }
}