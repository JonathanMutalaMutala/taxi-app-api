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
        private ICarOwner _carOwnerService { get; set; } 

        public CarOwnerController(ICarOwner carOwner)
        {
            _carOwnerService = carOwner;
        }

        [HttpGet]
        public async Task<ActionResult<List<CarOwner>>> GetAll()
        {
            return Ok( await _carOwnerService.GetCarOwnersAsync());
        }

        [HttpGet("{id}")]
        public ActionResult<CarOwner> GetById(int id)
        {
            return Ok(_carOwnerService.GetSingleCarOwnerAsync(id));
        }
    }
}
