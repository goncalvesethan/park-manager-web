using System.Text.Json.Serialization;

namespace Models
{
    public class Room
    {
        public required int Id { get; set; }
        public required int ParkId { get; set; }
        public required string Name { get; set; }
        public required string Type { get; set; }
        public required int Capacity { get; set; }
        
        [JsonIgnore]
        public Park? Park { get; set; }
    }
}