using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MoopelObjects.Entities;

[Table("Tags")]
[Index(nameof(Name), IsUnique = true)]
public class Tag
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TagId { get; set; }

    [Required, MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required, MaxLength(20)]
    public string HexColor { get; set; } = "ffffff";

    public ICollection<Note> Notes { get; set; } = [];
}
