    using Microsoft.EntityFrameworkCore;
    using WebApplication2.Models;

namespace WebApplication2.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, Name = "Dr. Ahmed Ali", Specialization = "Cardiology", ImageUrl = "https://i.imgur.com/8Km9tLL.jpg" },
                new Doctor { Id = 2, Name = "Dr. Sara Mohamed", Specialization = "Pediatrics", ImageUrl = "https://i.imgur.com/CP2TjA3.jpg" },
                new Doctor { Id = 3, Name = "Dr. Omar Hassan", Specialization = "Dermatology", ImageUrl = "https://i.imgur.com/FH1dZ3L.jpg" }
            );
        }
    }
}
