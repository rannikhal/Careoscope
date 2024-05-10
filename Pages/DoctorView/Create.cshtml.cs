using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Careoscope.Models;
using NuGet.Common;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Reflection.Metadata;

namespace Careoscope.Pages.DoctorView;

public class CreateModel : PageModel
{
    private readonly CareoscopeDbContext _context;
    private readonly ILogger<CreateModel> _logger;
    public List<Appointment> ListOfAppointments {get;set;} = default!;
    public IEnumerable<Appointment> TodayAppointments {get;set;} = default!;
    public DateTime Today {get;set;}
    public string? SelectorNumber {get;set;}

    public CreateModel(CareoscopeDbContext context, ILogger<CreateModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        SelectorNumber = "0";

        Today = DateTime.Today;
        
        ListOfAppointments = _context.Appointments.Include(a => a.Patient).Include(a => a.Doctor).ToList(); // adds all appointments to a list for the page to iterate them in a table

        TodayAppointments = ListOfAppointments.Where(a => a.AppointmentDate == Today).ToList();
    }
}
