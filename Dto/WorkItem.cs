using MoopelObjects.Enums;

namespace MoopelObjects.Dto;

public record WorkItem
{
    public required int ItemId { get; init; }
    public required int GroupId { get; init; }

    public required string Name { get; init; }
    public required string Description { get; init; }
    public required decimal Points { get; init; }

    public required WorkItemType Type { get; init; }

    public required DateTime CreatedAtUtc { get; init; }
}
