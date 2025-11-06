namespace MoopelObjects.Models.Dtos.NoteDtos;

public class NoteCreateDto
{
    public required int UserId { get; set; }
    public required string Group { get; set; }
    public required string Name { get; set; }
    public required string Content { get; set; }
    public List<int> TagIds { get; set; } = [];
}
