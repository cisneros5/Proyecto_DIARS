using Licoreria_SLOWLIFE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Licoreria_SLOWLIFE.BD.MAPS
{
    public class EmpleadoMap : EntityTypeConfiguration<Empleado>
    {
        public EmpleadoMap()
        {
            ToTable("Empleado");
            HasKey(o => o.idEmpleado);
        }
    }
}