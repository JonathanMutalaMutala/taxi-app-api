using System.ComponentModel.DataAnnotations.Schema;

namespace taxi_app_api.Models
{
    public class CarOwner
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string LicenseId { get; set; } = string.Empty;

        [ForeignKey("Car")]
        public Car? Car { get; set; }
        public int CarId { get; set; }
    }
}
