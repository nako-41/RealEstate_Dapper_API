using RealEstate_Dapper_API.Dtos.FormDto;
using RealEstate_Dapper_API.Dtos.WhoWeAreDetailDtos;

namespace RealEstate_Dapper_API.Repositories.FormRepository
{
    public interface IFormRepository
    {
        void CreateForm(CreateFormDto createFormDto);
        void DeleteForm(int id);
    }
}
