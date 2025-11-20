
using Microsoft.EntityFrameworkCore;
using Clinic_Management_System.Models;

namespace Clinic_Management_System.Data
{
    //EF core Database context for clinic management system
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Patient> Patients { get; set; }    
    }
}
