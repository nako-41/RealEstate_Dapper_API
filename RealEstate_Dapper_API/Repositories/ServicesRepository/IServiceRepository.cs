using RealEstate_Dapper_API.Dtos.CategoryDtos;
using RealEstate_Dapper_API.Dtos.ServiceDto;

namespace RealEstate_Dapper_API.Repositories.ServicesRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllCategoryAsync();
        Task<GetByIDServiceDto> GetCategoryID(int id);
        void CreateService(CreateServiceDto serviceDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto updateServiceDto);
    }
}
