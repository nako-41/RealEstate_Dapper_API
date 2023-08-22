using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Dtos.CategoryDtos;
using RealEstate_Dapper_API.Dtos.WhoWeAreDetailDtos;
using RealEstate_Dapper_API.Repositories.CategoryRepository;
using RealEstate_Dapper_API.Repositories.WhoWeAreRepository;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        private readonly IWhoWeAreDetailRepository _whoWeAreRepository;

        public WhoWeAreDetailController(IWhoWeAreDetailRepository whoWeAreRepository)
        {
            _whoWeAreRepository = whoWeAreRepository;
        }

         
        [HttpGet]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var values = await _whoWeAreRepository.GetAllWhoWeAreDetailAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> WhoWeAreDetailID(int id)
        {
            var values = await _whoWeAreRepository.GetWhoWeDetailID(id);
            return Ok(values);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            _whoWeAreRepository.CreateWhoWeDetail(createWhoWeAreDetailDto);
            return Ok("Hakkimizda basarili sekilde eklendi");
        }
        [HttpDelete]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
        {
            _whoWeAreRepository.DeleteWhoWeDetail(id);
            return Ok("Hakkimizda basarili sekilde silindi");
        }


        [HttpPut]
        //[ValidateAntiForgeryToken]                 
        public async Task<IActionResult> UpdateWhoWeAreDetail(UpdateWhoWeDetailDto updateWhoWeDetailDto)
        {
            _whoWeAreRepository.UpdateWhoWeDetail(updateWhoWeDetailDto);
            return Ok("Hakkimizda basarili sekilde guncellendi");
        }
    }
}
