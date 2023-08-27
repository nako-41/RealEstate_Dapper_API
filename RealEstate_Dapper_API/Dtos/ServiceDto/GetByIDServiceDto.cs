namespace RealEstate_Dapper_API.Dtos.ServiceDto
{
    public class GetByIDServiceDto
    {
        public int ServicesID { get; set; }
        public string ServiceName { get; set; }
        public bool ServiceStatus { get; set; }
    }
}
