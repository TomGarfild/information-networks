using SurveyBuilder.Domain.Domain.Models;

namespace SurveyBuilder.Data.Repositories;

public interface IRepository<TData> where TData : IHasId
{
    Task Create(TData data, CancellationToken ct);
    Task<TData?> GetOne(string id, CancellationToken ct);
    Task<ICollection<TData>> GetAll(CancellationToken ct);
}