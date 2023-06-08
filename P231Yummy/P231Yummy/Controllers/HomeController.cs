using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P231Yummy.DAL;
using P231Yummy.ViewModels;
using System.Diagnostics;

namespace P231Yummy.Controllers
{
    public class HomeController : Controller
    {
        private readonly YummyDbContext _context;

        public HomeController(YummyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Categories = _context.Categories
                .Include(x=>x.Meals)
                .ThenInclude(m=>m.MealIngredients).ThenInclude(mi=>mi.Ingredient)
                .ToList(),
            };
            return View(vm);
        }

    }
}