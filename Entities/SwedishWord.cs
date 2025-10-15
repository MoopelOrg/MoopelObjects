using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoopelObjects.Entities;

[Table("SwedishWords")]
public class SwedishWord
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WordId { get; set; }

    [Required]
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public User? User { get; set; }

    [Required, MaxLength(100)]
    public string Swedish { get; set; } = string.Empty;

    [Required, MaxLength(100)]
    public string English { get; set; } = string.Empty;

    [MaxLength(50)]
    public string PartOfSpeech { get; set; } = string.Empty; // noun, verb, adj, etc.

    public int CorrectCount { get; set; }
    public int IncorrectCount { get; set; }
    public DateTime LastReviewed { get; set; } = DateTime.UtcNow;

    // Optional: spaced repetition or difficulty tracking
    public int ProficiencyLevel { get; set; } = 0; // 0–5 scale
}
