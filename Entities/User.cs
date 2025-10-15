using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoopelObjects.Entities;

[Table("Users")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }

    [Required]
    [MaxLength(15)]
    [MinLength(4)]
    public string Username { get; set; } = string.Empty;

    [Column("Password")]
    [Required]
    public string PasswordHash { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public UserRole Role { get; set; } = UserRole.User;

    [Required]
    public DateTime CreationDate { get; set; }

    public ICollection<Login> Logins { get; set; } = [];
}

public enum UserRole
{
    Admin = 0,
    AdvancedUser = 1,
    User = 2
}
