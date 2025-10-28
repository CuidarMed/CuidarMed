using Domain.Entities;
using Infraestructure.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        //dbsets    
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User entity
            modelBuilder.Entity<User>(u =>
            {
                u.ToTable("User");
                u.HasKey(u => u.Id);
                u.Property(u => u.Id).ValueGeneratedOnAdd();
                u.Property(u => u.Name).HasMaxLength(100).IsRequired();
                u.Property(u => u.Email).HasMaxLength(100).IsRequired();
                u.Property(u => u.Password).HasMaxLength(100).IsRequired();

                // Enum conversion
                u.Property(u => u.Rol)
                 .HasConversion<int>()
                 .IsRequired();
            });

            // Patient entity
            modelBuilder.Entity<Patient>(p =>
            {
                p.ToTable("Patient");
                p.HasKey(p => p.PatientId);
                p.Property(p => p.Dni).IsRequired();
                p.Property(p => p.Adress).HasMaxLength(200);
                p.Property(p => p.DateOfBirth).IsRequired();
                p.Property(p => p.HealthPlan).HasMaxLength(100);
                p.Property(p => p.MembershipNumber).IsRequired();

                // Relationship with User
                p.HasOne(p => p.UserNavigation)
                 .WithOne(u => u.Patient)
                 .HasForeignKey<Patient>(p => p.UserId)
                 .OnDelete(DeleteBehavior.Cascade)
                 .IsRequired();

            });

            // Doctor entity
            modelBuilder.Entity<Doctor>(d =>
            {
                d.ToTable("Doctor");
                d.HasKey(d => d.DoctorId);
                d.Property(d => d.Specialty).HasMaxLength(100);
                d.Property(d => d.LicenseNumber).HasMaxLength(50);

                // Relationship with User
                d.HasOne(d => d.UserNavigation)
                 .WithOne(u => u.Doctor)
                 .HasForeignKey<Doctor>(d => d.UserId)
                 .OnDelete(DeleteBehavior.Cascade)
                 .IsRequired();
            });
            base.OnModelCreating(modelBuilder);

            //Precarga de datos
            modelBuilder.ApplyConfiguration(new DoctorSeed());
            modelBuilder.ApplyConfiguration(new PatientSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
        }
    } 
}
