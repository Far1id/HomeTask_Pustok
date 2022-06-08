using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok_Project.DAL;
using System.Linq;

namespace Pustok_Project.Areas.Manage.Controllers
{
    [Area("Manage")]

    public class BookController : Controller
    {

        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Books.Include(x => x.Genre).Include(x => x.Author).ToList();
            return View(data);
        }
    }
}
