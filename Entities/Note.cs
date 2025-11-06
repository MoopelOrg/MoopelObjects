namespace MoopelObjects.Entities;

public class Note
{
    public int NoteId { get; set; }
    public int UserId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? LastUpdate { get; set; }

    public required string GroupName { get; set; } = "None";

    public required string Name { get; set; }

    public required string Content { get; set; }

    public int Progress { get; set; } = 0;

    public User? User { get; set; } = null;

    public ICollection<Tag> Tags { get; set; } = [];
}