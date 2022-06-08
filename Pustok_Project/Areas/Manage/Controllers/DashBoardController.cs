using Microsoft.AspNetCore.Mvc;

namespace Pustok_Project.Areas.Manage.Controllers
{
    [Area("Manage")]

    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
