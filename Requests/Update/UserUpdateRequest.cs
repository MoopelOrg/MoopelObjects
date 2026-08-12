namespace MoopelObjects.Requests.Update;

public record UserUpdateRequest
{
    public string? Email { get; init; }
}
