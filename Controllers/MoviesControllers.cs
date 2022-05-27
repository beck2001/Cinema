using Microsoft.AspNetCore.Mvc;
using Cinema.Data;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Controllers
{
    public class MoviesControllers : Controller
    {
        private readonly AppDbContext _context;
        public MoviesControllers(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
