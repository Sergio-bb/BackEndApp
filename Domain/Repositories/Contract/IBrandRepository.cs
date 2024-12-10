using BackEndApp.Domain.Entities;

namespace BackEndApp.Domain.Repositories.Contract;

public interface IBrandRepository
{
    Task<List<Brand>> GetAllAsync();
}
