using System.Collections.Generic;
using System.Threading.Tasks;
using MiLibreriaWebApp.Models;
using MiLibreriaWebApp.Repositories;

namespace MiLibreriaWebApp.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _repository;

        public GenreService(IGenreRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Genre>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Genre?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Genre genre)
        {
            await _repository.AddAsync(genre);
        }

        public async Task UpdateAsync(Genre genre)
        {
            await _repository.UpdateAsync(genre);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
