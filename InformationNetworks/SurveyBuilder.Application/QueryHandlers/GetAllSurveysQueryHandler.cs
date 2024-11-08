using MediatR;
using SurveyBuilder.Application.Queries;
using SurveyBuilder.Data.Repositories;
using SurveyBuilder.Domain.Domain.Models;

namespace SurveyBuilder.Application.QueryHandlers;

public class GetAllSurveysQueryHandler(IRepository<Survey> repository) : IRequestHandler<GetAllSurveysQuery, ICollection<Survey>>
{
    public async Task<ICollection<Survey>> Handle(GetAllSurveysQuery request, CancellationToken cancellationToken)
    {
        var surveys = await repository.GetAll(cancellationToken);
        return surveys;
    }
}