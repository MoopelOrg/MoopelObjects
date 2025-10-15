using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoopelObjects.Entities;

[Table("Transactions")]
public class Transaction
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TransactionId { get; set; }

    [Required]
    public int BankId { get; set; }

    [ForeignKey("BankId")]
    public Bank? Bank { get; set; }

    [Required]
    public required decimal Amount { get; set; }

    [Required]
    public required TransactionType Type { get; set; }

    [Required]
    public required string Source { get; set; }

    [Required]
    public required TransactionCategory Category { get; set; }

    [MaxLength(255)]
    public string? Description { get; set; }

    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}

public enum TransactionType
{
    Deposit,
    Withdrawal,
    Transfer,
    Payment
}
public enum TransactionCategory
{
    Paycheck,
    Groceries,
    Food,
    Gas
}