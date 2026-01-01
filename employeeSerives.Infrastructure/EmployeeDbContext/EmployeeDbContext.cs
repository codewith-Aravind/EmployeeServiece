using employeeService.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace employeeServices.Infrastructure.EmployeeDbContext
{
    public class EmployeeDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly IDbConnection _connection;
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
            //_configuration = configuration;

            //string? connectionString = _configuration.GetConnectionString("EmployeeDBConnection");
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);
                entity.Property(e => e.EmployeeName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.EmployeeAge).IsRequired();
                entity.Property(e => e.Salary).IsRequired().HasColumnType("decimal(18,2)");
                entity.Property(e => e.CreatedDate).IsRequired();
                entity.Property(e => e.UpdatedDate).IsRequired();
                entity.ToTable("Employees");
            });
        }

    }
}
