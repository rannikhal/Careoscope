using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Careoscope.Models;

namespace Careoscope.Pages.DoctorView;

public class AllAppointmentsModel : PageModel
{
    private readonly CareoscopeDbContext _context;
    private readonly ILogger<AllAppointmentsModel> _logger;
    public List<Appointment> ListOfAppointments {get;set;} = default!;

    public AllAppointmentsModel(CareoscopeDbContext context, ILogger<AllAppointmentsModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    [BindProperty(SupportsGet = true)]
    public int PageNum {get;set;} = 1;
    public int PageSize {get;set;} = 10;
    public int MaxPageNum {get;set;}
    [BindProperty(SupportsGet = true)]
    public string? CurrentSort {get;set;}
    

    public async Task OnGetAsync()
    {
        var query = _context.Appointments.Select(a => a);

        switch (CurrentSort)
        {
            case "date_asc":
                query = query.OrderBy(a => a.AppointmentDate);
                break;
            case "date_desc":
                query = query.OrderByDescending(a => a.AppointmentDate);
                break;
        }

        ListOfAppointments = await query.Include(a => a.Patient).Include(a => a.Doctor).Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync(); // adds all appointments to a list for the page to iterate them in a table

        MaxPageNum = ListOfAppointments.Count()/10;
    }
    public IActionResult ClickPatient(int id)
    {
        return RedirectToPage($"/DoctorView/PatientSchedule?id={id}");
    }
}
