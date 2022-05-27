using Microsoft.AspNetCore.Mvc;
using Cinema.Data;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Controllers
{
    public class ProducersController : Controller
    {
        private AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Producers.ToListAsync();
            return View(data);
        }
    }
}
