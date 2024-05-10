using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Careoscope.Models;

namespace Careoscope.Pages;

public class IndexModel : PageModel
{
    private readonly CareoscopeDbContext _context;
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(CareoscopeDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
