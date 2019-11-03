using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Licoreria_SLOWLIFE.Models
{
    public class Admin
    {
        public int idAdmin { get; set; }
        public string usuario { get; set; }
        public string passwd { get; set; }
        public bool estado { get; set; }

    }
}