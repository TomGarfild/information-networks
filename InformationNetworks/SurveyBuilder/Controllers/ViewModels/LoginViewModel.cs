using System.ComponentModel.DataAnnotations;

namespace SurveyBuilder.Controllers.ViewModels;

public record LoginViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; init; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; init; }

    [Display(Name = "Remember me?")]
    public bool RememberMe { get; init; }
}