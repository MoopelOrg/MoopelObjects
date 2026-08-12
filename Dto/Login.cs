using MoopelObjects.Enums;

namespace MoopelObjects.Dto;

public record Login
{
    public required int LoginId { get; init; }

    public required string Username { get; init; }
    public required DateTime AttemptTimeUtc { get; init; }

    public required LoginStatus Status { get; init; }
}
