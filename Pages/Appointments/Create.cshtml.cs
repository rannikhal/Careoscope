using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Careoscope.Models;

namespace Careoscope.Pages.Appointments
{
    public class CreateModel : PageModel
    {
        private readonly Careoscope.Models.CareoscopeDbContext _context;

        public CreateModel(Careoscope.Models.CareoscopeDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DoctorID"] = new SelectList(_context.Doctors, "DoctorID", "DoctorID");
        ViewData["PatientID"] = new SelectList(_context.Patients, "PatientID", "PatientID");
            return Page();
        }

        [BindProperty]
        public Appointment Appointment { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Appointments.Add(Appointment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
