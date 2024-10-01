using System.ComponentModel.DataAnnotations;

namespace SurveyBuilder.Controllers.ViewModels;

public record RegisterViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; init; }
    
    [Required]
    [StringLength(100)]
    public string FullName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; init; }

    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; init; }
}