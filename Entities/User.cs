namespace MoopelObjects.Entities;

public class User
{
    public int UserId { get; set; }

    public required string Username { get; set; } = string.Empty;

    public required string PasswordHash { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public required UserRole Role { get; set; } = UserRole.User;

    public DateTime CreationDate { get; set; }
}

public enum UserRole
{
    Admin = 0,
    AdvancedUser = 1,
    User = 2
}
