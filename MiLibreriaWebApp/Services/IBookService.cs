using System.Collections.Generic;
using System.Threading.Tasks;
using MiLibreriaWebApp.Models;

namespace MiLibreriaWebApp.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
        Task AddAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(int id);
    }
}
