namespace MoopelObjects.Requests.Update;

public record TagUpdateRequest
{
    public required string Name { get; init; }
    public required string Color { get; init; }
}
