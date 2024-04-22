using System;
using Eterna.Data;
using Eterna.ViewsModel;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
	public class ServicesController:Controller
	{
        private AppDbContext _context;
        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ServicesViewModel serviveVM = new ServicesViewModel
            {
               Services=_context.Services.ToList()
            };
            return View(serviveVM);

        }
    }
}

