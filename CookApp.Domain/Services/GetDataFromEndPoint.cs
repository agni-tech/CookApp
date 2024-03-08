using CookApp.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CookApp.Domain.Services
{
    public class GetDataFromEndpoint
    {
        public async Task<List<MenuDTO>> GetData()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var apiUrl = "https://isol-grillassessment.azurewebsites.net/api/GrillMenu";
            using var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<MenuDTO>>(responseData, options);
            }
            else
            {
                throw new Exception($"Failed to fetch data from endpoint: {response.ReasonPhrase}");
            }
        }
    }
}
