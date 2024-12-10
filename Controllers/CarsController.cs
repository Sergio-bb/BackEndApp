using BackEndApp.Domain.Entities;
using BackEndApp.Domain.Responses;
using BackEndApp.Domain.Services.contract;
using Microsoft.AspNetCore.Mvc;

namespace BackEndApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController(ILogger<CarsController> logger, IBrandService brandService) : ControllerBase
    {

        [HttpGet("[action]")]
        public async Task<IActionResult> GetBrands()
        {
            try
            {
                var result = await brandService.GetAllBrandsAsync();
                return Ok(new BaseResponse<List<Brand>>(true, "The operation is completed correctly.", result));
            }
            catch (Exception e)
            {
                return BadRequest(new BaseResponse<object>(true, "something has gone wrong, try again.", null));
            }
        }
    }
}
