using Microsoft.AspNetCore.Identity;

namespace SurveyBuilder.Domain.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; }
}