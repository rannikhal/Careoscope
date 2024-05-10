using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Careoscope.Models;
using NuGet.Common;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Reflection.Metadata;

namespace Careoscope.Pages.DoctorView;

public class CreateDoctorModel : PageModel
{
    private readonly CareoscopeDbContext _context;
    private readonly ILogger<CreateDoctorModel> _logger;
    public List<Doctor> ListOfDoctors {get;set;} = default!;
    public IEnumerable<Doctor> TodayDoctors {get;set;} = default!;
    public DateTime Today {get;set;}
    public string? SelectorNumber {get;set;}

    public CreateDoctorModel(CareoscopeDbContext context, ILogger<CreateDoctorModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
