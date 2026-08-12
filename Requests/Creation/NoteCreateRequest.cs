using MoopelObjects.Enums;

namespace MoopelObjects.Requests.Creation;

public record NoteCreateRequest
{
    public required NoteType Type { get; init; }
    public required string Title { get; init; }
    public required string Content { get; init; }
}
