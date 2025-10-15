namespace MoopelObjects.Models.Dtos.AuthDtos;

public class ForgotPasswordResponseDto
{
    public bool Success { get; set; }
    public required string Message { get; set; }
}
