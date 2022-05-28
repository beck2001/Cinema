using Microsoft.AspNetCore.Mvc;
using Cinema.Data;
using Cinema.Data.Services;
using Cinema.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;

        public CinemasController(ICinemasService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("CinemaLogo,Name,Description")]CinemaPlace cinema)
        {
            if (!ModelState.IsValid) return View(cinema);
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }
    }
}
