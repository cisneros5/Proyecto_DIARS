using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Licoreria_SLOWLIFE.Models
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public int stock { get; set; }
        public string descripcion { get; set; }
        public string fechaElaboracion { get; set; }


        public Marca marca { get; set; }
        public int idMarca { get; set; }


        public Tipo tipo { get; set; }
        public int idTipo { get; set; }
    }
}