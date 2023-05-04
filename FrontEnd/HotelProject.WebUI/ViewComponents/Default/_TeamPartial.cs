using HotelProject.WebUI.DTOs.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _TeamPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _TeamPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            HttpClient client = _httpClientFactory.CreateClient();
            HttpResponseMessage responseMessage = await client.GetAsync("http://localhost:1903/api/Staffs");
            if (responseMessage.IsSuccessStatusCode)
            {
                string jsonData = await responseMessage.Content.ReadAsStringAsync();
                List<ResultStaffDto> values = JsonConvert.DeserializeObject<List<ResultStaffDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
