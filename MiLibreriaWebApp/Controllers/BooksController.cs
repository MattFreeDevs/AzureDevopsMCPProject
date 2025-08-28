using Microsoft.AspNetCore.Mvc;
using MiLibreriaWebApp.Models;
using MiLibreriaWebApp.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MiLibreriaWebApp.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _service;
        private readonly ICountryService _countryService;
        private readonly IGenreService _genreService;

        public BooksController(IBookService service, ICountryService countryService, IGenreService genreService)
        {
            _service = service;
            _countryService = countryService;
            _genreService = genreService;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            var books = await _service.GetAllAsync();
            return View(books);
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var book = await _service.GetByIdAsync(id.Value);
            if (book == null)
                return NotFound();

            return View(book);
        }

        // GET: Books/Create
        public async Task<IActionResult> Create()
        {
            await PopulateDropdowns();
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Author,CountryId,GenreId,ISBN,ReadingStatus")] Book book)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(book);
                return RedirectToAction(nameof(Index));
            }
            await PopulateDropdowns();
            return View(book);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var book = await _service.GetByIdAsync(id.Value);
            if (book == null)
                return NotFound();
            await PopulateDropdowns();
            return View(book);
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Author,CountryId,GenreId,ISBN,ReadingStatus")] Book book)
        {
            if (id != book.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                await _service.UpdateAsync(book);
                return RedirectToAction(nameof(Index));
            }
            await PopulateDropdowns();
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var book = await _service.GetByIdAsync(id.Value);
            if (book == null)
                return NotFound();

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateDropdowns()
        {
            var countries = await _countryService.GetAllAsync();
            var genres = await _genreService.GetAllAsync();
            ViewBag.CountryId = new SelectList(countries, "Id", "Name");
            ViewBag.GenreId = new SelectList(genres, "Id", "Name");
            ViewBag.ReadingStatus = new SelectList(System.Enum.GetValues(typeof(ReadingStatus)));
        }
    }
}