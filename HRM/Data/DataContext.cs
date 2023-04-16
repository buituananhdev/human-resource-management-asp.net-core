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
            optionsBuilder.UseSqlServer("Server=DESKTOP-3GPHECN\\SQLEXPRESS;Database=HRM;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
