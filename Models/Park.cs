using System.Text.Json.Serialization;

namespace Models
{
    public class Park
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Location { get; set; }
    }
}