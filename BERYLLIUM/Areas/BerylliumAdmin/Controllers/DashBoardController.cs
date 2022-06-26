using BERYLLIUM.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BERYLLIUM.Areas.BerylliumAdmin.Controllers
{
    [Area("BerylliumAdmin")]
    [Authorize(Roles = nameof(Role.RoleType.Admin))]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
