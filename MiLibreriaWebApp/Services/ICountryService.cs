using System.Collections.Generic;
using System.Threading.Tasks;
using MiLibreriaWebApp.Models;

namespace MiLibreriaWebApp.Services
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetAllAsync();
        Task<Country?> GetByIdAsync(int id);
        Task AddAsync(Country country);
        Task UpdateAsync(Country country);
        Task DeleteAsync(int id);
    }
}
