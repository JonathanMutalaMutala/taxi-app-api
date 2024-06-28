using taxi_app_api.Dtos;
using taxi_app_api.Models;

namespace taxi_app_api.Services.Contracts
{
    public interface ICarOwner
    {
        Task<List<CarOwner>> GetCarOwnersAsync();

        Task<CarOwner> GetSingleCarOwnerAsync(int id);

        Task CreateCarOwnerAsync(CarOwnerDto carOwnerDto);

        Task<CarOwner> UpdateCarOwnerAsync(CarOwnerDto carOwnerDto);

        /// <summary>
        /// Supprimer un CarOwner 
        /// </summary>
        /// <param name="id">Represente l'id du car owner à supprimer</param>
        /// <returns></returns>
        Task DeleteCarOwnerAsync(int id);

    }
}
