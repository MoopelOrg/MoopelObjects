using System.Net;

namespace MoopelApi.Models;

public class AuthRequestDto
{
    public required IPAddress ClientIP { get; set; }
    public required bool IsBrowser { get; set; }
    public required string UserAgent { get; set; }
}
