using Dapper;
using RealEstate_Dapper_API.Dtos.FormDto;
using RealEstate_Dapper_API.Dtos.WhoWeAreDetailDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.FormRepository
{
    public class FormRepository : IFormRepository
    {
        private readonly Context _context;

        public FormRepository(Context context)
        {
            _context = context;
        }

        public async void CreateForm(CreateFormDto createFormDto)
        {
            string query = "insert into Form (FullName,Email,Message) values(@FullName,@Email,@Message)";
            var parameters = new DynamicParameters();
            parameters.Add("@FullName", createFormDto.FullName);
            parameters.Add("@Email", createFormDto.Email);
            parameters.Add("@Message", createFormDto.Message);
            using (var con = _context.CreateConnection())
            {
                await con.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteForm(int id)
        {
            string query = "Delete from Form where  FormID=@formID";
            var parameters = new DynamicParameters();
            parameters.Add("@formID", id);
            using (var con = _context.CreateConnection())
            {
                await con.ExecuteAsync(query, parameters);
            }

        }
    }
}
