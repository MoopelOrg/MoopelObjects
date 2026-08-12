namespace MoopelObjects.Dto.Read;

public record TransactionRead : Transaction
{
    public required List<TransactionItem> Items { get; init; }
}
