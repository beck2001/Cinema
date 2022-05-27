using Microsoft.AspNetCore.Mvc;
using Cinema.Data;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context; 
        }
        public async Task<IActionResult> Index()
        {
            var data = _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
