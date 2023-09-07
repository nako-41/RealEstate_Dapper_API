using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.Dtos.WhoWeAreDto;

namespace RealEstate_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultWhoWeAreComponentPartial:ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultWhoWeAreComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async  Task<IViewComponentResult> InvokeAsync()
        {
            var client=_httpClientFactory.CreateClient();
            var client2=_httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7052/api/WhoWeAreDetail");
            var responseMessage2 = await client2.GetAsync("https://localhost:7052/api/WhoWeAreDetail");

            if (responseMessage.IsSuccessStatusCode && responseMessage2.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();
                var value=JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDto>>(jsondata);
                var value2=JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsondata);
                ViewBag.a = value.Select(x=>x.Title).FirstOrDefault();
                return View(value2);
            }

            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    var jsondata = await responseMessage.Content.ReadAsStringAsync();
            //    var value = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsondata);

            //    var servicelist = value.Select(x => x.ServiceName).FirstOrDefault();
            //    return View(servicelist);
            //}


            return View();
        }
    }
}
