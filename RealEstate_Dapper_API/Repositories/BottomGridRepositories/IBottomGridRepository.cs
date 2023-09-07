using RealEstate_Dapper_API.Dtos.BottomGridDtos;

namespace RealEstate_Dapper_API.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        Task<GetBottomGridDto> GetBottomGridID(int id);
        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
    }
}
