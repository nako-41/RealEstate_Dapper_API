using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.TestimonialRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestiMonialController : ControllerBase
    {
        private readonly ITestimonialRepository _estimonialRepository;
        private readonly ILogger<TestiMonialController> _logger;

        public TestiMonialController(ITestimonialRepository estimonialRepository, ILogger<TestiMonialController> logger)
        {
            _estimonialRepository = estimonialRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
           var  result=await _estimonialRepository.GetAllTestimonialAsync();
            return Ok(result);
        }
    }
}
