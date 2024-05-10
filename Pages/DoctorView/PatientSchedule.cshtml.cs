using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Careoscope.Models;

namespace Careoscope.Pages.PatientView;

public class IndexModel : PageModel
{
    private readonly CareoscopeDbContext _context;
    private readonly ILogger<IndexModel> _logger;
    public List<Appointment> ListOfAppointments {get;set;} = default!;

    public IndexModel(CareoscopeDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        
        ListOfAppointments = _context.Appointments.Include(a => a.Patient).Include(a => a.Doctor).ToList(); // adds all appointments to a list for the page to iterate them in a table
    }
}
