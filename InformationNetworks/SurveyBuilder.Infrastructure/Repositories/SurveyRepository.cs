using Microsoft.EntityFrameworkCore;
using SurveyBuilder.Domain.Domain.Models;

namespace SurveyBuilder.Data.Repositories;

public class SurveyRepository(AppDbContext context) : IRepository<Survey>
{
    public async Task Create(Survey survey, CancellationToken ct)
    {
        context.Surveys.Add(survey);
        await context.SaveChangesAsync(ct);
    }

    public async Task<Survey?> GetOne(string id, CancellationToken ct)
    {
        return await context.Surveys.Include(s => s.Questions).FirstOrDefaultAsync(s => s.Id == id, ct);
    }

    public async Task<ICollection<Survey>> GetAll(CancellationToken ct)
    {
        return await context.Surveys.Include(s => s.Questions).ToListAsync(ct);
    }
}