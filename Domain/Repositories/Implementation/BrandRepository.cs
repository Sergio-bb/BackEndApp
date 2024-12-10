using BackEndApp.Data;
using BackEndApp.Domain.Entities;
using BackEndApp.Domain.Repositories.Contract;
using Microsoft.EntityFrameworkCore;

namespace BackEndApp.Domain.Repositories.Implementation;

public class BrandRepository(ApplicationDbContext context) :IBrandRepository
{
    public async Task<List<Brand>> GetAllAsync()
    {
        return await context.Brands.ToListAsync();
    }
}
