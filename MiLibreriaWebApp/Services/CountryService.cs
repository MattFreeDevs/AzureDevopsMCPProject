using System.Collections.Generic;
using System.Threading.Tasks;
using MiLibreriaWebApp.Models;
using MiLibreriaWebApp.Repositories;

namespace MiLibreriaWebApp.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _repository;

        public CountryService(ICountryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Country>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Country?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Country country)
        {
            await _repository.AddAsync(country);
        }

        public async Task UpdateAsync(Country country)
        {
            await _repository.UpdateAsync(country);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
