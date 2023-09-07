using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.BottomGridRepositories;
using RealEstate_Dapper_API.Repositories.BottomGridRepository;
using RealEstate_Dapper_API.Repositories.CategoryRepository;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;
        private readonly ILogger<BottomGridsController> _logger;

        public BottomGridsController(IBottomGridRepository bottomGridRepository, ILogger<BottomGridsController> logger)
        {
            _bottomGridRepository = bottomGridRepository;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var values = await _bottomGridRepository.GetAllBottomGridAsync();
            return Ok(values);
        }
    }
}
