using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Careoscope.Models;

namespace Careoscope.Pages.Appointments
{
    public class IndexModel : PageModel
    {
        private readonly Careoscope.Models.CareoscopeDbContext _context;

        public IndexModel(Careoscope.Models.CareoscopeDbContext context)
        {
            _context = context;
        }

        public IList<Appointment> Appointment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Appointment = await _context.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient).ToListAsync();
        }
    }
}
