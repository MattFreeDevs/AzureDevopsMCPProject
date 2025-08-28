using System.Collections.Generic;
using System.Threading.Tasks;
using MiLibreriaWebApp.Models;
using MiLibreriaWebApp.Repositories;

namespace MiLibreriaWebApp.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Book book)
        {
            await _repository.AddAsync(book);
        }

        public async Task UpdateAsync(Book book)
        {
            await _repository.UpdateAsync(book);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
