using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Dtos.FormDto;
using RealEstate_Dapper_API.Repositories.FormRepository;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormAddController : ControllerBase
    {
        private readonly IFormRepository _formRepository;

        public FormAddController(IFormRepository formRepository)
        {
            _formRepository = formRepository;
        }

        [HttpPost]
        public async Task<ActionResult> FormAdd(CreateFormDto createFormDto) 
        {
            _formRepository.CreateForm(createFormDto);
            return Ok("Form başarıyla gonderildi");
        }

        [HttpDelete]
        public async Task<ActionResult> FormDelete(int id)
        {
            _formRepository.DeleteForm(id);
            return Ok("Silme işlemi gerçekleştirildi");
        }
    }
}
