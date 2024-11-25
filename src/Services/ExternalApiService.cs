using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiGateway.src.Dtos;
using apiGateway.src.Interfaces;

namespace apiGateway.src.Services
{
    public class ExternalApiService : IExternalApi
    {
        public async Task<ApiResponse> GetExternalApiAsync(string apiUrl)
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync(apiUrl);

                if (!response.IsSuccessStatusCode)
                {
                    return ApiResponse.Create(
                        false,
                        "Failed to fetch data from external API.",
                        response.Content.ReadAsStringAsync().Result
                    );
                }

                var content = await response.Content.ReadAsStringAsync();
                return ApiResponse.Create(true, "Data retrieved successfully", content);
            }
            catch (Exception ex)
            {
                return ApiResponse.Create(false, ex.Message);
            }
        }
    }
}