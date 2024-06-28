using taxi_app_api.Dtos;
using taxi_app_api.Models;
using taxi_app_api.Services.Contracts;

namespace taxi_app_api.Services
{
    public class CarOwnerService : ICarOwner
    {
        public Task CreateCarOwnerAsync(CarOwnerDto carOwnerDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCarOwnerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarOwner>> GetCarOwnersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CarOwner> GetSingleCarOwnerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CarOwner> UpdateCarOwnerAsync(CarOwnerDto carOwnerDto)
        {
            throw new NotImplementedException();
        }
    }
}
