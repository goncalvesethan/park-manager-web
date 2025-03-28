namespace Models
{
    public class Device
    {
        public required int Id { get; set; }
        public required int ParkId { get; set; }
        public required int RoomId { get; set; }
        public string? Processor { get; set; }
        public int? Ram { get; set; }
        public int? Storage { get; set; }
        public required string MacAddress { get; set; }
        public string? IpAddress { get; set; }
        public bool IsOnline { get; set; } = false;
    }
}