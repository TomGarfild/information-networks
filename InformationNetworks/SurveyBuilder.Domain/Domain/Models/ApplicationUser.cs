using Microsoft.AspNetCore.Identity;

namespace SurveyBuilder.Domain.Domain.Models;

public class ApplicationUser : IdentityUser
{
    public required string FullName { get; init; }
}