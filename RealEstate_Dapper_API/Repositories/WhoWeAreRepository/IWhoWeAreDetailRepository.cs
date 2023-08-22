
using RealEstate_Dapper_API.Dtos.WhoWeAreDetailDtos;

namespace RealEstate_Dapper_API.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDtos>> GetAllWhoWeAreDetailAsync();
        Task<GetByIdWhoWeDetailDto> GetWhoWeDetailID(int id);
        void CreateWhoWeDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        void DeleteWhoWeDetail(int id);
        void UpdateWhoWeDetail(UpdateWhoWeDetailDto updateWhoWeDetailDto);
    }
} 
