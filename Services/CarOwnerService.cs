using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using taxi_app_api.DatabaseContext;
using taxi_app_api.Dtos;
using taxi_app_api.Exceptions;
using taxi_app_api.Models;
using taxi_app_api.Services.Contracts;

namespace taxi_app_api.Services
{
    public class CarOwnerService : ICarOwner
    {
        private readonly TaxiAppDbContext _dbContext;

        public CarOwnerService(TaxiAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task CreateCarOwnerAsync(CarOwnerDto carOwnerDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCarOwnerAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CarOwner>> GetCarOwnersAsync()
        {
            return  _dbContext.CarOwners.ToList();
        }

        public CarOwner GetSingleCarOwnerAsync(int id)
        {

            var carOwner = this._dbContext.CarOwners.FirstOrDefault(x => x.Id == id);   

            if(carOwner == null)
            {
                throw new NotFoundException(nameof(CarOwner), id); 
            }

            return carOwner; 
        }

        public Task<CarOwner> UpdateCarOwnerAsync(CarOwnerDto carOwnerDto)
        {
            throw new NotImplementedException();
        }
    }
}
