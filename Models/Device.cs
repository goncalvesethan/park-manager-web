using System.Text.Json.Serialization;

namespace Models
{
    public class Device
    {
        public int Id { get; set; }
        public int ParkId { get; set; }
        public int RoomId { get; set; }
        public string? Processor { get; set; }
        public int? Ram { get; set; }
        public int? Storage { get; set; }
        public string MacAddress { get; set; }
        public string? IpAddress { get; set; }
        public bool IsOnline { get; set; } = false;
        [JsonIgnore]
        public Park? Park { get; set; }
        [JsonIgnore]
        public Room? Room { get; set; }
    }
}