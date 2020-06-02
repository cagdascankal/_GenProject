using GeneralProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralProject.DataAccess.Maps
{
    public class EmployeAddressMaps : IEntityTypeConfiguration<EmployeeAddress>
    {
        public void Configure(EntityTypeBuilder<EmployeeAddress> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id).HasName("Id_Index");
            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
