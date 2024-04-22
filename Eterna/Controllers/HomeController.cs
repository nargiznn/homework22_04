using System.Diagnostics;
using Eterna.Data;
using Eterna.ViewsModel;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers;

public class HomeController : Controller
{

    private AppDbContext _context;
    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        HomeViewModel homeVM = new HomeViewModel
        {
            Features = _context.Features.ToList()
        };
        return View(homeVM);
        
    }

}

