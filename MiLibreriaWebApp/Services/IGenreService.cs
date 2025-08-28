using System.Collections.Generic;
using System.Threading.Tasks;
using MiLibreriaWebApp.Models;

namespace MiLibreriaWebApp.Services
{
    public interface IGenreService
    {
        Task<IEnumerable<Genre>> GetAllAsync();
        Task<Genre?> GetByIdAsync(int id);
        Task AddAsync(Genre genre);
        Task UpdateAsync(Genre genre);
        Task DeleteAsync(int id);
    }
}
