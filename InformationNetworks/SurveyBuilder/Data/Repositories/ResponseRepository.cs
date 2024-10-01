using SurveyBuilder.Domain.Models;

namespace SurveyBuilder.Data.Repositories;

public class ResponseRepository(AppDbContext context) : IRepository<Response>
{
    public Task Create(Response data, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public Task<Response?> GetOne(string id, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Response>> GetAll(CancellationToken ct)
    {
        throw new NotImplementedException();
    }
}