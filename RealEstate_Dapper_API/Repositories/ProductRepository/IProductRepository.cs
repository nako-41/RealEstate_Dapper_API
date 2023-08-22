
using RealEstate_Dapper_API.Dtos.ProductDtos;

namespace RealEstate_Dapper_API.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDtos>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategory();
    }
}
