using Licoreria_SLOWLIFE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Licoreria_SLOWLIFE.BD.MAPS
{
    public class ProductoMap : EntityTypeConfiguration<Producto>
    {
        public ProductoMap()
        {
            ToTable("Producto");
            HasKey(o => o.idProducto);

            HasRequired(o => o.marca).WithMany().HasForeignKey(o => o.idMarca);
            HasRequired(o => o.tipo).WithMany().HasForeignKey(o => o.idTipo);
        }
    }
}