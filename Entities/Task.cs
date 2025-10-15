using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MoopelObjects.Entities;

[Index(nameof(UserId))]
[Index(nameof(Group))]
[Index(nameof(Status))]
[Table("Tasks")]
public class Task
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TaskId { get; set; }

    [Required]
    public int UserId { get; set; }

    public int? ParentTaskId { get; set; }

    [ForeignKey(nameof(ParentTaskId))]
    public Task? ParentTask { get; set; }

    public ICollection<Task> SubTasks { get; set; } = [];


    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? LastUpdate { get; set; }

    [Required]
    public required TaskStatus Status { get; set; } = TaskStatus.New;
    [Required]
    public required TaskPriority Priority { get; set; } = TaskPriority.Low;


    public DateTime? DueDate { get; set; }

    [Required, MaxLength(50)]
    public required string Group { get; set; } = "None";

    [Required, MaxLength(50)]
    public required string Name { get; set; }

    [Required]
    public required string Content { get; set; }

    [Range(0, 100)]
    public int Progress { get; set; } = 0;

    [ForeignKey("UserId")]
    public User? User { get; set; } = null;
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