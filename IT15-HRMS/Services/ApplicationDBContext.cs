using IT15_HRMS.Models;
using Microsoft.EntityFrameworkCore;

namespace IT15_HRMS.Services
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        // DbSet properties representing the tables

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Onboarding> Onboardings { get; set; }
        

        // Fluent API configurations for relationships (if needed)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define the one-to-many relationship between Employee and Attendance
            modelBuilder.Entity<Attendance>()
                .HasOne(a => a.Employee)
                .WithMany(e => e.Attendances)
                .HasForeignKey(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Define the one-to-many relationship between Employee and Payroll
            modelBuilder.Entity<Payroll>()
                .HasOne(p => p.Employee)
                .WithMany(e => e.Payrolls)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Define the one-to-one relationship between Employee and Onboarding
            modelBuilder.Entity<Onboarding>()
                .HasOne(o => o.Employee)
                .WithOne(e => e.Onboarding)
                .HasForeignKey<Onboarding>(o => o.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Define the relationship between Applicant and Employee (optional)
            modelBuilder.Entity<Applicant>()
                .HasOne(a => a.Employee)
                .WithOne(e => e.Applicant)
                .HasForeignKey<Applicant>(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull); // You can change the delete behavior if necessary
        }
    }
}

