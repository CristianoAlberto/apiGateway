using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiGateway.src.Interfaces;
using apiGateway.src.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiGateway.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiGatewayController : ControllerBase
    {
        private readonly IExternalApi _externalApi;
        public ApiGatewayController(IExternalApi service)
        {
            _externalApi = service;
        }
        [HttpGet("all-provinces")]
        public async Task<IActionResult> GettAllProvincesOfAngola()
        {
            var result = await _externalApi.GetExternalApiAsync("https://angolaapi.onrender.com/api/v1/geography/provinces");
            return Ok(result);
        }
        [HttpGet("is-bi-valid/{bi}")]
        public async Task<IActionResult> IsBiValid(string bi)
        {
            var result = await _externalApi.GetExternalApiAsync($"https://angolaapi.onrender.com/api/v1/validate/bi/{bi}");
            return Ok(result);
        }
        [HttpGet("is-passport-valid/{passport}")]
        public async Task<IActionResult> IsPassportValid(string passport)
        {
            var result = await _externalApi.GetExternalApiAsync($"https://angolaapi.onrender.com/api/v1/validate/passport/{passport}");
            return Ok(result);
        }
    }
}