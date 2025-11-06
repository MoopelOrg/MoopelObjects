namespace MoopelObjects.Entities;

public class Login
{
    public int LoginId { get; set; }
    public int UserId { get; set; }

    public DateTime LoginTime { get; set; }

    public required LoginStatus Status { get; set; } = LoginStatus.Success;

    public required LoginType Type { get; set; }

    public string Source { get; set; } = string.Empty;

    // accommodates IPv6
    public required string IPAddress { get; set; }

    // Device Info (user-agent, etc.)
    public string? DeviceInfo { get; set; }

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