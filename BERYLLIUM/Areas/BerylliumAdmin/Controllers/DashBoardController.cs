using Microsoft.AspNetCore.Mvc;

namespace BERYLLIUM.Areas.BerylliumAdmin.Controllers
{
    [Area("BerylliumAdmin")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
