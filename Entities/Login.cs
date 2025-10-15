using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoopelObjects.Entities;

[Table("Logins")]
public class Login
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LoginId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public DateTime LoginTime { get; set; }

    [Required]
    public required LoginStatus Status { get; set; } = LoginStatus.Success;

    [Required]
    public required LoginType Type { get; set; }

    [Required]
    [MaxLength(50)]
    public string Source { get; set; } = string.Empty;

    [MaxLength(45)] // accommodates IPv6
    public required string IPAddress { get; set; }

    // Device Info (user-agent, etc.)
    [MaxLength(200)]
    public string? DeviceInfo { get; set; }

    [ForeignKey("UserId")]
    public User? User { get; set; } = null;
}
public enum LoginStatus
{
    Success,
    Failure,
    Blocked,
    InProgress
}
public enum LoginType
{
    Login,
    Logout
}