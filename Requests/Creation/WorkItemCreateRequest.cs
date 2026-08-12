using MoopelObjects.Enums;

namespace MoopelObjects.Requests.Creation;

public record WorkItemCreateRequest
{
    public required string Name { get; init; }
    public required string Description { get; init; }

    public required decimal Points { get; init; }
    public required WorkItemType Type { get; init; }
}
