using BERYLLIUM.DAL;
using BERYLLIUM.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BERYLLIUM.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel
            {
                Works = _context.Works.ToList(),
                Sliders = _context.Sliders.ToList(),
            };
            return View(home);
        }
    }
}
