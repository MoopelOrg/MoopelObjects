using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MoopelObjects.Entities;

[Index(nameof(UserId))]
[Index(nameof(Group))]
[Index(nameof(Name))]
[Table("Notes")]
public class Note
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int NoteId { get; set; }
    [Required]
    public int UserId { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? LastUpdate { get; set; }

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

    public ICollection<Tag> Tags { get; set; } = [];
}