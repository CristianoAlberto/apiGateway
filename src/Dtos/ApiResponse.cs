using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiGateway.src.Dtos
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public required string Message { get; set; }
        public object? Data { get; set; }

        public static ApiResponse Create(bool success, string message, object? data = null)
        {
            return new ApiResponse
            {
                Success = success,
                Message = message,
                Data = data
            };
        }
    }
}