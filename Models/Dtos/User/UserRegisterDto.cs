namespace MoopelObjects.Models.Dtos.User;

public class UserRegisterDto
{
    public required string Username { get; set; }
    public required string Password { get; set; }
    public string? Email { get; set; }
}
