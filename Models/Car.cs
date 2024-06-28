namespace taxi_app_api.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string TypeName { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string LicensePlate { get; set; } = string.Empty;
        public int NumberOfPerson { get; set; }
        public bool IsActive { get; set; }
        public CarOwner? CarOwner { get; set; }
    }
}
