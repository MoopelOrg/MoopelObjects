using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoopelObjects.Entities;

[Table("Banks")]
public class Bank
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BankId { get; set; }

    [Required]
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public User? User { get; set; } = null;

    [Required, MaxLength(100)]
    public string BankName { get; set; } = "Personal Bank";

    [MaxLength(3)]
    public string Currency { get; set; } = "USD";

    public decimal Balance { get; set; }

    public ICollection<Transaction> Transactions { get; set; } = [];
}
