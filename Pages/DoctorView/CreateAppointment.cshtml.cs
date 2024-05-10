using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Careoscope.Models;
using NuGet.Common;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Careoscope.Pages.DoctorView;

public class CreateAppointmentModel : PageModel
{
    private readonly CareoscopeDbContext _context;
    private readonly ILogger<CreateAppointmentModel> _logger;
    public List<Appointment> ListOfAppointments {get;set;} = default!;
    public List<Patient> ListOfPatients {get;set;} = default!;
    public List<Doctor> ListOfDoctors {get;set;} = default!;
    public IEnumerable<Appointment> TodayAppointments {get;set;} = default!;
    public DateTime Today {get;set;}
    public int SelectorNumber {get;set;}
    public Appointment Appointment {get;set;} = default!;
    public Patient Patient {get;set;} = default!;
    public Doctor Doctor {get;set;} = default!;

    public SelectList PatientDropDown {get;set;} = default!;
    public SelectList DoctorDropDown {get;set;} = default!;

    public CreateAppointmentModel(CareoscopeDbContext context, ILogger<CreateAppointmentModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        SelectorNumber = 0;

        Today = DateTime.Today;
        
        ListOfAppointments = _context.Appointments.Include(a => a.Patient).Include(a => a.Doctor).ToList(); // adds all appointments to a list for the page to iterate them in a table

        ListOfPatients = _context.Patients.ToList();

        PatientDropDown = new SelectList(ListOfPatients, "PatientID", "FirstName");

        ListOfDoctors = _context.Doctors.ToList();

        DoctorDropDown = new SelectList(ListOfDoctors, "DoctorID", "LastName");

        TodayAppointments = ListOfAppointments.Where(a => a.AppointmentDate == Today).ToList();
    }
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Appointments.Add(Appointment);
        _context.SaveChanges();

        return RedirectToPage("Index");
    }
}
