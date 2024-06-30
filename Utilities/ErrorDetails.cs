using System.Text.Json;

namespace taxi_app_api.Utilities
{
    public class ErrorDetails 
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
