using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    public string DisplayName { get; set; } = string.Empty;

    [EmailAddress]
    [Required]
    public required string Email { get; set; } = string.Empty;

    [MinLength(4)]
    [Required]
    public required string Password { get; set; } = string.Empty;
}