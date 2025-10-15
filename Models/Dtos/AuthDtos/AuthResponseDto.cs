namespace MoopelObjects.Models.Dtos.AuthDtos;

public class AuthResponseDto
{
    public required string Token { get; set; }
    public required DateTime ExpiresAt { get; set; }
}
