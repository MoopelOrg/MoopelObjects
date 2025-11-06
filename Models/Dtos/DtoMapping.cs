using MoopelObjects.Entities;
using MoopelObjects.Models.Dtos.LoginDtos;
using MoopelObjects.Models.Dtos.NoteDtos;
using MoopelObjects.Models.Dtos.UserDtos;

namespace MoopelObjects.Models.Dtos;

public static class DtoMapping
{
    public static UserReadDto ToReadDto(this User user) => new()
    {
        UserId = user.UserId,
        Username = user.Username,
        Email = user.Email,
        Role = user.Role,
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

    public static NoteReadDto ToReadDto(this Note note) => new()
    {
        NoteId = note.NoteId,
        Group = note.GroupName,
        Name = note.Name,
        Content = note.Content,
        CreatedAt = note.CreatedAt,
        LastUpdate = note.LastUpdate,
        Tags = [.. note.Tags]
    };
}
