using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Careoscope.Models;
using NuGet.Common;

namespace Careoscope.Pages.DoctorView;

public class IndexModel : PageModel
{
    private readonly CareoscopeDbContext _context;
    private readonly ILogger<IndexModel> _logger;
    public List<Appointment> ListOfAppointments {get;set;} = default!;
    public IEnumerable<Appointment> TodayAppointments {get;set;} = default!;
    public DateTime Today;

    public IndexModel(CareoscopeDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        Today = DateTime.Today;
        
        ListOfAppointments = _context.Appointments.Include(a => a.Patient).Include(a => a.Doctor).ToList(); // adds all appointments to a list for the page to iterate them in a table

        TodayAppointments = ListOfAppointments.Where(a => a.AppointmentDate == Today).ToList();
    }
}
