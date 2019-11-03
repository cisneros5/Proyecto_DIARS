using Licoreria_SLOWLIFE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Licoreria_SLOWLIFE.BD.MAPS
{
    public class DetalleVentaMap : EntityTypeConfiguration<DetalleVenta>
    {

        public DetalleVentaMap()
        {
            ToTable("DetalleVenta");
            HasKey(o => o.idDetalleVenta);

            HasRequired(o => o.producto).WithMany().HasForeignKey(o => o.idProducto);
            HasRequired(o => o.venta).WithMany().HasForeignKey(o => o.idVenta);
            HasRequired(o => o.empleado).WithMany().HasForeignKey(o => o.idEmpleado);

        }

    }
}