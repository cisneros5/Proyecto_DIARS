namespace Licoreria_SLOWLIFE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        idAdmin = c.Int(nullable: false, identity: true),
                        usuario = c.String(),
                        passwd = c.String(),
                        estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idAdmin);
            
            CreateTable(
                "dbo.DetalleVenta",
                c => new
                    {
                        idDetalleVenta = c.Int(nullable: false, identity: true),
                        idProducto = c.Int(nullable: false),
                        idVenta = c.Int(nullable: false),
                        idEmpleado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idDetalleVenta)
                .ForeignKey("dbo.Empleado", t => t.idEmpleado, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.idProducto, cascadeDelete: true)
                .ForeignKey("dbo.Venta", t => t.idVenta, cascadeDelete: true)
                .Index(t => t.idProducto)
                .Index(t => t.idVenta)
                .Index(t => t.idEmpleado);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        idEmpleado = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellidoP = c.String(),
                        apellidoM = c.String(),
                        ciudad = c.String(),
                        fechaIngreso = c.String(),
                        estado = c.Boolean(nullable: false),
                        usuario = c.String(),
                        passwd = c.String(),
                    })
                .PrimaryKey(t => t.idEmpleado);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        idProducto = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        precio = c.Single(nullable: false),
                        stock = c.Int(nullable: false),
                        descripcion = c.String(),
                        fechaElaboracion = c.String(),
                        idMarca = c.Int(nullable: false),
                        idTipo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idProducto)
                .ForeignKey("dbo.Marca", t => t.idMarca, cascadeDelete: true)
                .ForeignKey("dbo.Tipo", t => t.idTipo, cascadeDelete: true)
                .Index(t => t.idMarca)
                .Index(t => t.idTipo);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        idMarca = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.idMarca);
            
            CreateTable(
                "dbo.Tipo",
                c => new
                    {
                        idTipo = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        descripcion = c.String(),
                    })
                .PrimaryKey(t => t.idTipo);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        idVenta = c.Int(nullable: false, identity: true),
                        fecha = c.String(),
                        nota = c.String(),
                        estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idVenta);
            
            CreateTable(
                "dbo.RegistroAdmin",
                c => new
                    {
                        idRegistroAdmin = c.Int(nullable: false, identity: true),
                        accion = c.String(),
                        idAdmin = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idRegistroAdmin)
                .ForeignKey("dbo.Admin", t => t.idAdmin, cascadeDelete: true)
                .Index(t => t.idAdmin);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegistroAdmin", "idAdmin", "dbo.Admin");
            DropForeignKey("dbo.DetalleVenta", "idVenta", "dbo.Venta");
            DropForeignKey("dbo.DetalleVenta", "idProducto", "dbo.Producto");
            DropForeignKey("dbo.Producto", "idTipo", "dbo.Tipo");
            DropForeignKey("dbo.Producto", "idMarca", "dbo.Marca");
            DropForeignKey("dbo.DetalleVenta", "idEmpleado", "dbo.Empleado");
            DropIndex("dbo.RegistroAdmin", new[] { "idAdmin" });
            DropIndex("dbo.Producto", new[] { "idTipo" });
            DropIndex("dbo.Producto", new[] { "idMarca" });
            DropIndex("dbo.DetalleVenta", new[] { "idEmpleado" });
            DropIndex("dbo.DetalleVenta", new[] { "idVenta" });
            DropIndex("dbo.DetalleVenta", new[] { "idProducto" });
            DropTable("dbo.RegistroAdmin");
            DropTable("dbo.Venta");
            DropTable("dbo.Tipo");
            DropTable("dbo.Marca");
            DropTable("dbo.Producto");
            DropTable("dbo.Empleado");
            DropTable("dbo.DetalleVenta");
            DropTable("dbo.Admin");
        }
    }
}
