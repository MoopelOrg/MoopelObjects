using MoopelObjects.Entities;

namespace MoopelObjects.Models.Dtos.NoteDtos;

public class NoteReadDto
{
    public int NoteId { get; set; }

    public required DateTime CreatedAt { get; set; }

    public DateTime? LastUpdate { get; set; }

    public required string Group { get; set; }

    public required string Name { get; set; }

    public required string Content { get; set; }

    public List<Tag> Tags { get; set; } = [];
}
