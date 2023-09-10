using RealEstate_Dapper_API.Dtos.BottomGridDtos;
using RealEstate_Dapper_API.Dtos.TestiMomialDtos;

namespace RealEstate_Dapper_API.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        //Task<GetTestimonialDto> GetTestimonialID(int id);
        //void CreateTestimonial(CreateTestimonialDto createTestimonialDto);
        //void DeleteTestimonial(int id);
        //void UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto);
    }
}
