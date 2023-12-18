using Employee_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Employee_Management_System.AppDbContext
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public MyDbContext()
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("dbConnection");
            }



            //optionsBuilder
            //    .UseSqlServer(
            //    "Server=tcp:interview-tasks.database.windows.net,1433;" +
            //    "Initial Catalog=iasonas.ps;Persist Security Info=False;" +
            //    "User ID=interview;" +
            //    "Password=1nterv13w$!;" +
            //    "MultipleActiveResultSets=False;" +
            //    "Encrypt=True;" +
            //    "TrustServerCertificate=False;" +
            //    "Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentID)
                .IsRequired(false);
        }

        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
    }
}
