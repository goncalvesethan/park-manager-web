using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Models;

public class User
{
    public int Id { get; set; }
    public string Lastname { get; set; }
    public string Firstname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
    
    [JsonIgnore]
    public string Name => $"{Firstname} {Lastname}";
}
