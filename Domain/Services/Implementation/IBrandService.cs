using BackEndApp.Domain.Entities;
using BackEndApp.Domain.Repositories.Contract;
using BackEndApp.Domain.Services.contract;

namespace BackEndApp.Domain.Services.Implementation
{
    public class BrandService(IBrandRepository brandRepository) : IBrandService
    {
        public async Task<List<Brand>> GetAllBrandsAsync()
        {
            return await brandRepository.GetAllAsync();
        }
    }
}
