using Microsoft.EntityFrameworkCore;
using System;
using EmployeeCRUDTask.Domain;
namespace EmployeeCRUDTask.DAL
{
    public class  EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }
        //congigure relation between employee and departement (one to many)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne<Departement>(e => e.Departement)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartementId);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Departement> Departements { get; set; }
    }
}
