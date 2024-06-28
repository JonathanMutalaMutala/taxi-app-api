using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taxi_app_api.Models;
using taxi_app_api.Services.Contracts;

namespace taxi_app_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarOwnerController : ControllerBase
    {
        private ICarService CarService { get; set; } 

        public CarOwnerController(ICarService carService)
        {
            CarService = carService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CarOwner>>> Get()
        {
            return Ok();
        }
    }
}
