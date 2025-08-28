using Microsoft.AspNetCore.Mvc;
using MiLibreriaWebApp.Models;
using MiLibreriaWebApp.Services;
using System.Threading.Tasks;

namespace MiLibreriaWebApp.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService _service;

        public GenreController(IGenreService service)
        {
            _service = service;
        }

        // GET: Genre
        public async Task<IActionResult> Index()
        {
            var genres = await _service.GetAllAsync();
            return View(genres);
        }

        // GET: Genre/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Genre/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")] Genre genre)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(genre);
                return RedirectToAction(nameof(Index));
            }
            return View(genre);
        }

        // POST: Genre/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
