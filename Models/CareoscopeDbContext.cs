using Microsoft.EntityFrameworkCore;

namespace Careoscope.Models
{
    public class CareoscopeDbContext : DbContext
    {
        public CareoscopeDbContext (DbContextOptions<CareoscopeDbContext> options)
            : base(options)
            {
            }
            public DbSet<Doctor> Doctors {get;set;} = default!;
            public DbSet<Patient> Patients {get;set;} = default!;
            public DbSet<Appointment> Appointments {get;set;} = default!;
    }
}