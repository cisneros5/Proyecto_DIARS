using Licoreria_SLOWLIFE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Licoreria_SLOWLIFE.BD.MAPS
{
    public class RegistroAdminMap : EntityTypeConfiguration<RegistroAdmin>
    {
        public RegistroAdminMap()
        {
            ToTable("RegistroAdmin");
            HasKey(o => o.idRegistroAdmin);

            HasRequired(o => o.admin).WithMany().HasForeignKey(o => o.idAdmin);
        }
    }
}