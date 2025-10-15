using System.Net;

namespace MoopelObjects.Models.Dtos.AuthDtos;

public class AuthRequestDto
{
    public required IPAddress ClientIP { get; set; }
    public required bool IsBrowser { get; set; }
    public required string UserAgent { get; set; }
}
