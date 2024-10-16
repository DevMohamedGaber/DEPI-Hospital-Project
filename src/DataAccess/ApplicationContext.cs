using DataAccess.Abstacts;
using DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts
{
    public class ApplicationContext : IdentityDbContext<Staff, IdentityRole<uint>, uint>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}
        // Actors
        public DbSet<Patient> Patients { get; set; }

        // Others
        public DbSet<Appointment> Appointments { get; set; }
    }
}
