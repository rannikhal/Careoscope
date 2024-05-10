using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Careoscope.Models;
using NuGet.Common;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Reflection.Metadata;

namespace Careoscope.Pages.DoctorView;

public class CreatePatientModel : PageModel
{
    private readonly CareoscopeDbContext _context;
    private readonly ILogger<CreatePatientModel> _logger;
    public List<Patient> ListOfPatients {get;set;} = default!;
    public IEnumerable<Patient> TodayPatients {get;set;} = default!;
    public DateTime Today {get;set;}
    public string? SelectorNumber {get;set;}

    public CreatePatientModel(CareoscopeDbContext context, ILogger<CreatePatientModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        
    }
}
