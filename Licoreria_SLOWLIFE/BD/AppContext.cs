using Licoreria_SLOWLIFE.BD.MAPS;
using Licoreria_SLOWLIFE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Licoreria_SLOWLIFE.BD
{
    public class AppContext : DbContext
    {

        public IDbSet<Admin> Admins { get; set; }
        public IDbSet<DetalleVenta> DetalleVentas { get; set; }
        public IDbSet<Empleado> Empleados { get; set; }
        public IDbSet<Marca> Marcas { get; set; }
        public IDbSet<Producto> Productos { get; set; }
        public IDbSet<RegistroAdmin> RegistroAdmins { get; set; }
        public IDbSet<Tipo> Tipos { get; set; }
        public IDbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AdminMap());
            modelBuilder.Configurations.Add(new DetalleVentaMap());
            modelBuilder.Configurations.Add(new EmpleadoMap());
            modelBuilder.Configurations.Add(new MarcaMap());
            modelBuilder.Configurations.Add(new ProductoMap());
            modelBuilder.Configurations.Add(new RegistroAdminMap());
            modelBuilder.Configurations.Add(new TipoMap());
            modelBuilder.Configurations.Add(new VentaMap());
        }


    }
}