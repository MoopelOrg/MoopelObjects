using MoopelObjects.Enums;

namespace MoopelObjects.Requests.Update;

public record WorkItemUpdateRequest
{
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public decimal Points { get; init; } = decimal.Zero;
    public WorkItemType Type { get; init; }
}
