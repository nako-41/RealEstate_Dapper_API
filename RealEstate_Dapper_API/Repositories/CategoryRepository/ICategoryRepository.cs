using RealEstate_Dapper_API.Dtos.CategoryDtos;

namespace RealEstate_Dapper_API.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {

        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task<GetByIDCategoryDto> GetCategoryID(int id);
        void CreateCategory(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto updateCategoryDto);


    }
}
