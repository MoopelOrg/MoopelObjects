using MoopelObjects.Entities;

namespace MoopelObjects.Models.Dtos.Login;

public record LoginReadDto
{
    public required int LoginId { get; set; }
    public required int UserId { get; set; }
    public required DateTime LoginTime { get; set; }
    public string? DeviceInfo { get; set; }
    public required LoginStatus Status { get; set; }
    public required LoginType Type { get; set; }
}
