using Dapper;
using RealEstate_Dapper_API.Dtos.CategoryDtos;
using RealEstate_Dapper_API.Dtos.WhoWeAreDetailDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.WhoWeAreRepository
{
    public class WhoWeAreDetailRepository : IWhoWeAreDetailRepository
    {
        private readonly Context _context;

        public WhoWeAreDetailRepository(Context context)
        {
            _context = context;
        }

        public async void CreateWhoWeDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            string query = "insert into WhoWeAreDetail (Title,SubTitle,Description1,Description2) values(@Title,@SubTitle,@Description1,@Description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@Title", createWhoWeAreDetailDto.Title);
            parameters.Add("@SubTitle", createWhoWeAreDetailDto.SubTitle);
            parameters.Add("@Description1", createWhoWeAreDetailDto.Description1);
            parameters.Add("@Description2", createWhoWeAreDetailDto.Description2);
            using (var con = _context.CreateConnection())
            {
                await con.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeDetail(int id)
        {
            string query = "Delete from WhoWeAreDetail where WhoWeAreDetailID=@WhoWeAreDetailid";
            var parameters = new DynamicParameters();
            parameters.Add("@WhoWeAreDetailid", id);
            using (var con = _context.CreateConnection())
            {
                await con.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDtos>> GetAllWhoWeAreDetailAsync()
        {
            string query = "Select * from WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDtos>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdWhoWeDetailDto> GetWhoWeDetailID(int id)
        {
            string query = "Select * from WhoWeAreDetail where WhoWeAreDetailID=@WhoWeAreDetailid";
            var parameters = new DynamicParameters();
            parameters.Add("@WhoWeAreDetailid", id);
            using (var con = _context.CreateConnection())
            {
                var values = await con.QueryFirstAsync<GetByIdWhoWeDetailDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateWhoWeDetail(UpdateWhoWeDetailDto updateWhoWeDetailDto)
        {
            string query = "Update WhoWeAreDetail Set Title=@Title,SubTitle=@SubTitle,Description1=@Description1 where WhoWeAreDetailID=@WhoWeAreDetailid";

            var parameters = new DynamicParameters();
            parameters.Add("@Title", updateWhoWeDetailDto.Title);
            parameters.Add("@SubTitle", updateWhoWeDetailDto.SubTitle);
            parameters.Add("@Description1", updateWhoWeDetailDto.Description1);
            parameters.Add("@Description2", updateWhoWeDetailDto.Description2);
            parameters.Add("@WhoWeAreDetailid", updateWhoWeDetailDto.WhoWeAreDetailID);

            using (var con = _context.CreateConnection())
            {
                await con.ExecuteAsync(query, parameters);
            }
        }
    }
}
