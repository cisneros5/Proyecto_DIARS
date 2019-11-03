using Licoreria_SLOWLIFE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Licoreria_SLOWLIFE.BD.MAPS
{
    public class AdminMap : EntityTypeConfiguration<Admin>
    {
        public AdminMap()
        {
            ToTable("Admin");
            HasKey(o => o.idAdmin);
        }
    }
}