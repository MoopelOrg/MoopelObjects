namespace MoopelObjects.Entities;

public class Task
{
    public int TaskId { get; set; }

    public int UserId { get; set; }

    public int? ParentTaskId { get; set; }

    public Task? ParentTask { get; set; }

    public ICollection<Task> SubTasks { get; set; } = [];

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? LastUpdate { get; set; }

    public required TaskStatus Status { get; set; } = TaskStatus.New;
    public required TaskPriority Priority { get; set; } = TaskPriority.Low;


    public DateTime? DueDate { get; set; }

    public required string Group { get; set; } = "None";

    public required string Name { get; set; }

    public required string Content { get; set; }

    public int Progress { get; set; } = 0;

    public ICollection<Tag> Tags { get; set; } = [];
}

public enum TaskStatus
{
    New,
    InProgress,
    Completed,
}
public enum TaskPriority
{
    Low = 0,
    Normal = 1,
    High = 2,
    Critical = 3
}