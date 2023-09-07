using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Dtos.CategoryDtos;
using RealEstate_Dapper_API.Models.DapperContext;
using RealEstate_Dapper_API.Repositories.CategoryRepository;
using System.Data;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ICategoryRepository categoryRepository, ILogger<CategoriesController> logger)
        {
            _categoryRepository = categoryRepository;
            _logger = logger;
        }


        [HttpGet]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryRepository.GetAllCategoryAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> CategoryID(int id)
        {
            var result = _categoryRepository.GetCategoryID(id);

            if (result == null )
            {
                _logger.LogInformation("there is not id");
                //return NotFound("id bulunamadi");
            }

            else
            {
                if (result.Id == null)
                    return NotFound();
                else
                {
                    try
                    {

                        var result2 =await _categoryRepository.GetCategoryID(id);
                        _logger.LogInformation("category geldi");
                        //return result2;
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "categori getirilemedi tekrar deneyiniz");
                        return BadRequest(ex.Message);
                    }
                }
            }

            var values =await _categoryRepository.GetCategoryID(id);

            return Ok(values);

           // return Ok();



        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryRepository.CreateCategory(createCategoryDto);
            return Ok("Kategori basarili sekilde eklendi");
        }
        [HttpDelete]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok("Kategori basarili sekilde silindi");
        }


        [HttpPut]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryRepository.UpdateCategory(updateCategoryDto);
            return Ok("Kategori basarili sekilde guncellendi");
        }



    }
}
