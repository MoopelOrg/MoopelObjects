namespace MoopelObjects.Models.Dtos.Auth;

public class AuthResponseDto
{
    public required string Token { get; set; }
    public required DateTime ExpiresAt { get; set; }
}
