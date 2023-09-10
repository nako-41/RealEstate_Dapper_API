using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.BottomGridRepository;
using RealEstate_Dapper_API.Repositories.PopularLocationRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocationRepository;
        private readonly ILogger<PopularLocationController> _logger;

        public PopularLocationController(IPopularLocationRepository popularLocationRepository, ILogger<PopularLocationController> logger)
        {
            _popularLocationRepository = popularLocationRepository;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var values = await _popularLocationRepository.GetAllPopularLocationAsync();
            return Ok(values);
        }
    }
}
