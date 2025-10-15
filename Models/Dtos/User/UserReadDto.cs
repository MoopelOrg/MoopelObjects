using MoopelObjects.Entities;

namespace MoopelObjects.Models.Dtos.User;

public record UserReadDto
{
    public int UserId { get; set; }
    public required string Username { get; set; }
    public UserRole Role { get; set; }
    public string? Email { get; set; }
    public bool IsEmailVerified { get; set; }
    public string? ProfilePictureUrl { get; set; }
}
