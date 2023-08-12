using RealEstate_Dapper_API.Dtos.CategoryDtos;

namespace RealEstate_Dapper_API.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {

        Task<List<ResultCategoryDto>> GetAllCategoryAsync(); 

    }
}
