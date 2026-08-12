namespace MoopelObjects.Dto.Read;

public record StorageRead : Storage
{
    public required List<StorageItem> Items { get; init; }
}
