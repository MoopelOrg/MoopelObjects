namespace MoopelObjects.Requests.Update;

public record TransactionUpdateRequest
{
    public required string Name { get; init; }
    public required string Description { get; init; }
}
