﻿using Microsoft.AspNetCore.Mvc;
using Pustok_Project.DAL;
using System.Linq;

namespace Pustok_Project.Areas.Manage.Controllers
{
    [Area("Manage")]

    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;

        public AuthorController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var data = _context.Authors.ToList();
            return View(data);
        }
    }
}
