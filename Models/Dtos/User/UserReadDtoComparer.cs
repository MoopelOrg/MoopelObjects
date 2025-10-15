namespace MoopelApi.Models.Dtos.Comparer;

public class UserReadDtoComparer : IEqualityComparer<UserReadDto?>
{
    public bool Equals(UserReadDto? x, UserReadDto? y)
    {
        if (x is null && y is null) return true;
        if (x is null || y is null) return false;

        return x.Username == y.Username &&
               x.Email == y.Email &&
               x.Role == y.Role &&
               x.IsEmailVerified == y.IsEmailVerified;
        // optionally include UserId if relevant
    }

    public int GetHashCode(UserReadDto obj)
    {
        return HashCode.Combine(obj.Username, obj.Email, obj.Role, obj.IsEmailVerified);
    }
}
