using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworxDataLayer.Entities
{
    public class OrganizationContext : DbContext
    {
        public DbSet<Employee> Employee;
        public DbSet<EmployeeStatus> EmployeeStatus;
        public OrganizationContext() : base("name = OrganizationDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Employee>().ToTable("tbl_employee_m");
            modelBuilder.Entity<EmployeeStatus>().ToTable("tbl_employee_Status_m");
        }
    }

}
