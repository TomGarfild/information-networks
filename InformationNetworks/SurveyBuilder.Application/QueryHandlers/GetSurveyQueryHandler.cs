using MediatR;
using SurveyBuilder.Application.Queries;
using SurveyBuilder.Data.Repositories;
using SurveyBuilder.Domain.Domain.Models;

namespace SurveyBuilder.Application.QueryHandlers;

public class GetSurveyQueryHandler(IRepository<Survey> repository) : IRequestHandler<GetSurveyQuery, Survey?>
{
    public async Task<Survey?> Handle(GetSurveyQuery request, CancellationToken cancellationToken)
    {
        var survey = await repository.GetOne(request.Id, cancellationToken);
        return survey;
    }
}