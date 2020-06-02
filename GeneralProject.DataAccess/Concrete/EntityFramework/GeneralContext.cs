using GeneralProject.DataAccess.Maps;
using GeneralProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralProject.DataAccess.Concrete.EntityFramework
{
    public class GeneralContext:DbContext
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=.;Database=CagdasCoreDb;Trusted_Connection=true");  
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeMaps());
            modelBuilder.ApplyConfiguration(new EmployeAddressMaps()); 
            base.OnModelCreating(modelBuilder);
        }



        public DbSet<EmployeeAddress> EmployeeAddresss { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
