using Microsoft.EntityFrameworkCore;
using Stomatology.Models;

namespace Stomatology.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {      
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor_Procedure>().HasKey(dp => new
            {
                dp.ProcedureId,
                dp.DoctorId
            });

            modelBuilder.Entity<Doctor_Procedure>().HasOne(m => m.Doctor).WithMany(dp => dp.Doctors_Procedures).HasForeignKey(m => m.DoctorId);
            modelBuilder.Entity<Doctor_Procedure>().HasOne(m => m.Procedure).WithMany(dp => dp.Doctors_Procedures).HasForeignKey(m => m.ProcedureId);

            base.OnModelCreating(modelBuilder); 
        }

        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Doctor_Procedure> Doctors_Procedures { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
