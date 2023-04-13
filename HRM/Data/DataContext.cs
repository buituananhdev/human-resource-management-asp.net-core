using HRM.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=HRM;Trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<Employee> Assets { get; set; }

        public DbSet<Department> Users { get; set; }
    }
}
