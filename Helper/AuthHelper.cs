using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using MoopelApi.Config;
using MoopelObjects.Entities;
using MoopelObjects.Models.Dtos.AuthDtos;

namespace MoopelObjects.Helper;

public class AuthHelper
{
    public static Login GenerateLoginAttempt(int userId, AuthRequestDto authRequest)
    {
        return new()
        {
            UserId = userId,
            Status = LoginStatus.InProgress,
            Type = LoginType.Login,
            Source = authRequest.IsBrowser ? "Browser" : "App",
            IPAddress = authRequest.ClientIP.ToString(),
            DeviceInfo = authRequest.UserAgent
        };
    }
    public static Login GenerateCompleteLogin(int userId, AuthRequestDto authRequest)
    {
        return new()
        {
            UserId = userId,
            LoginTime = DateTime.UtcNow,
            Status = LoginStatus.Success,
            Type = LoginType.Login,
            Source = authRequest.IsBrowser ? "Browser" : "App",
            IPAddress = authRequest.ClientIP.ToString(),
            DeviceInfo = authRequest.UserAgent
        };
    }

    public static Login GenerateCompleteLogout(int userId, AuthRequestDto authRequest)
    {
        return new()
        {
            UserId = userId,
            LoginTime = DateTime.UtcNow,
            Status = LoginStatus.Success,
            Type = LoginType.Logout,
            Source = authRequest.IsBrowser ? "Browser" : "App",
            IPAddress = authRequest.ClientIP.ToString(),
            DeviceInfo = authRequest.UserAgent
        };
    }

    public static AuthRequestDto? GetAuthRequestData(HttpContext context)
    {
        var request = context.Request;
        var connection = context.Connection;

        IPAddress? clientIp = connection.RemoteIpAddress;

        if (clientIp is null)
        {
            string? ipString = request.Headers["CF-Connecting-IP"].FirstOrDefault()
                               ?? request.Headers["X-Forwarded-For"].FirstOrDefault()
                               ?? connection.RemoteIpAddress?.ToString();
            IPAddress.TryParse(ipString, out var cloudflareIp);
            if (cloudflareIp is null)
            {
                return null;
            }
            else
            {
                clientIp = cloudflareIp;
            }
        }

        string userAgent = request.Headers["User-Agent"].ToString();

        bool isBrowser = userAgent.Contains("Mozilla", StringComparison.OrdinalIgnoreCase)
                      || userAgent.Contains("Chrome", StringComparison.OrdinalIgnoreCase)
                      || userAgent.Contains("Safari", StringComparison.OrdinalIgnoreCase)
                      || userAgent.Contains("Edge", StringComparison.OrdinalIgnoreCase);

        return new AuthRequestDto
        {
            ClientIP = clientIp,
            IsBrowser = isBrowser,
            UserAgent = userAgent
        };
    }
}

public class AuthServiceHelper
{
    public static string GenerateToken(User user, JwtSettings jwtSettings)
    {
        {
            List<Claim> claims =
            [
                new(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new(ClaimTypes.Name, user.Username),
                new(ClaimTypes.Email, user.Email),
                new(ClaimTypes.Role, user.Role.ToString())
            ];

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(jwtSettings.JwtKey)
                );

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var tokenDescriptor = new JwtSecurityToken(
                issuer: jwtSettings.Issuer,
                audience: jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: creds
                );

            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }
    }

    public static string HashPassword(User user, string password)
    {
        return new PasswordHasher<User>().HashPassword(user, password);
    }

    public static PasswordVerificationResult VerifyPassword(User user, string password)
    {
        return new PasswordHasher<User>().VerifyHashedPassword(user, user.PasswordHash, password);
    }
}