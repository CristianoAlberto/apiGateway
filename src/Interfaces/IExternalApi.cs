using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiGateway.src.Dtos;

namespace apiGateway.src.Interfaces
{
    public interface IExternalApi
    {
        Task<ApiResponse> GetExternalApiAsync(string apiUrl);
    }
}