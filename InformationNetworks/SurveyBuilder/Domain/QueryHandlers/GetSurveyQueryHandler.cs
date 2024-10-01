using MediatR;
using SurveyBuilder.Data.Repositories;
using SurveyBuilder.Domain.Models;
using SurveyBuilder.Domain.Queries;

namespace SurveyBuilder.Domain.QueryHandlers;

public class GetSurveyQueryHandler(IRepository<Survey> repository) : IRequestHandler<GetSurveyQuery, Survey?>
{
    public async Task<Survey?> Handle(GetSurveyQuery request, CancellationToken cancellationToken)
    {
        var survey = await repository.GetOne(request.Id, cancellationToken);
        return survey;
    }
}