using MoopelApi.Models.Entities;

namespace MoopelObjects.Models.Dtos;

public static class DtoMapping
{
    public static UserReadDto ToReadDto(this User user) => new()
    {
        UserId = user.UserId,
        Username = user.Username,
        Email = user.Email,
        Role = user.Role
    };

    public static LoginReadDto ToReadDto(this Login login) => new()
    {
        LoginId = login.LoginId,
        UserId = login.UserId,
        LoginTime = login.LoginTime,
        DeviceInfo = login.DeviceInfo,
        Status = login.Status,
        Type = login.Type
    };
}
