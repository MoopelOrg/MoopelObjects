namespace MoopelObjects.Models.Dtos.Auth;

public class ForgotPasswordResponseDto
{
    public bool Success { get; set; }
    public required string Message { get; set; }
}
