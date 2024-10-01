using MediatR;
using SurveyBuilder.Data.Repositories;
using SurveyBuilder.Domain.Models;
using SurveyBuilder.Domain.Queries;

namespace SurveyBuilder.Domain.QueryHandlers;

public class GetAllSurveysQueryHandler(IRepository<Survey> repository) : IRequestHandler<GetAllSurveysQuery, ICollection<Survey>>
{
    public async Task<ICollection<Survey>> Handle(GetAllSurveysQuery request, CancellationToken cancellationToken)
    {
        var surveys = await repository.GetAll(cancellationToken);
        return surveys;
    }
}