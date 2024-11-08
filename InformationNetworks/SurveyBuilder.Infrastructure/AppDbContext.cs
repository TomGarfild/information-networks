using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SurveyBuilder.Domain.Domain.Models;

namespace SurveyBuilder.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<QuestionOption> QuestionOptions { get; set; }
    public DbSet<Response> Responses { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Survey> Surveys { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }
}
