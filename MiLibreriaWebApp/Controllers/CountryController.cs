using Microsoft.AspNetCore.Mvc;
using MiLibreriaWebApp.Models;
using MiLibreriaWebApp.Services;
using System.Threading.Tasks;

namespace MiLibreriaWebApp.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryService _service;

        public CountryController(ICountryService service)
        {
            _service = service;
        }

        // GET: Country
        public async Task<IActionResult> Index()
        {
            var countries = await _service.GetAllAsync();
            return View(countries);
        }

        // GET: Country/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Country/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")] Country country)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(country);
                return RedirectToAction(nameof(Index));
            }
            return View(country);
        }

        // POST: Country/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
