namespace MoopelObjects.Requests.Update;

public record FridgeUpdateRequest
{
    public required string Name { get; set; }
    public required string Description { get; set; }
}
