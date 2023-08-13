using Dapper;
using RealEstate_Dapper_API.Dtos.CategoryDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async void CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = "insert into Category (CategoryName,CategoryStatus) values(@categoryname,@categorystatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryname", categoryDto.CategoryName);
            parameters.Add("@categorystatus", true);
            using (var con=_context.CreateConnection())
            {
                await con.ExecuteAsync(query, parameters);
            }

        }

        public async void DeleteCategory(int id)
        {
            string query = "Delete from Category where  CategoryID=@categoryid";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryid",id);
            using (var con=_context.CreateConnection())
            {
                await con.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * from Category";
            using (var connection=_context.CreateConnection())
            {
                var values=await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList(); 
            }
        }

        public async Task<GetByIDCategoryDto> GetCategoryID(int id)
        {
            string query = "Select * from Category where CategoryID=@categoryid";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryid", id);
            using (var con = _context.CreateConnection())
            {
                var values =await con.QueryFirstAsync<GetByIDCategoryDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            string query = "Update Category Set CategoryName=@categoryname,CategoryStatus=@categorystatus where CategoryID=@categoryid";

            var parameters = new DynamicParameters();
            parameters.Add("@categoryname", updateCategoryDto.CategoryName);
            parameters.Add("@categorystatus", updateCategoryDto.CategoryStatus);
            parameters.Add("@categoryid", updateCategoryDto.CategoryID);

            using (var con = _context.CreateConnection())
            {
                await con.ExecuteAsync(query, parameters);
            }
            
        }
    } 
}
