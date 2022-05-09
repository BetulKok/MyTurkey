using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyTurkey.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyTurkey.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UlkeContext _db;

        public HomeController(ILogger<HomeController> logger, UlkeContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(int? bolgeId)
        {
            var vm = new HomeViewModel()
            {   
                    BolgeId=bolgeId,
                    Bolgeler = _db.Bolgeler.Select(b => new SelectListItem()
                    {
                        Text= b.BolgeAd, Value=b.Id.ToString()
                    
                    }).ToList(),
                    Sehirler= _db.Sehirler.Include(x=> x.Bolge).Where(x=> !bolgeId.HasValue  || x.BolgeId== bolgeId).ToList()
            };
            return View(vm);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
