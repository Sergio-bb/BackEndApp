using BackEndApp.Domain.Entities;

namespace BackEndApp.Domain.Services.contract;

public interface IBrandService
{
    Task<List<Brand>> GetAllBrandsAsync();
}
