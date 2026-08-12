namespace MoopelObjects.Requests.Update;

public record BankAccountUpdateRequest
{
    public required string Name { get; set; }
    public required string Description { get; set; }
}
