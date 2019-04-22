/*
 @auther: Hasan Skaiky
 */

using SkaikySolutions.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SkaikySolutions.DAL
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext() : base("EmployeeContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}