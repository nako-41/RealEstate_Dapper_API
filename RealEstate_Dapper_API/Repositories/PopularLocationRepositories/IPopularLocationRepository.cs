using RealEstate_Dapper_API.Dtos.BottomGridDtos;
using RealEstate_Dapper_API.Dtos.PopularLocationDtos;

namespace RealEstate_Dapper_API.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        //Task<GetPopularLocationDto> GetBottomGridID(int id);
        //void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        //void DeletePopularLocation(int id);
        //void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
    }
}
