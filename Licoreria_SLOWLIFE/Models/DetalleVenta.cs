using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Licoreria_SLOWLIFE.Models
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }


        public Producto producto { get; set; }
        public int idProducto { get; set; }


        public Venta venta { get; set; }
        public int idVenta { get; set; }

        public Empleado empleado { get; set; }
        public int idEmpleado { get; set; }
    }
}