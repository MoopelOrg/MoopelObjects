using MoopelObjects.Entities;

namespace MoopelObjects.Models.Dtos.NoteDtos;

public class NoteUpdateDto
{
    public required string Group { get; set; }

    public required string Name { get; set; }

    public required string Content { get; set; }

    public List<Tag> Tags { get; set; } = [];
}
