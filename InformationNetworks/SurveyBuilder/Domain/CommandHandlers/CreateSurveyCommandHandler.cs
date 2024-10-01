using Mapster;
using MediatR;
using SurveyBuilder.Data.Repositories;
using SurveyBuilder.Domain.Commands;
using SurveyBuilder.Domain.Models;

namespace SurveyBuilder.Domain.CommandHandlers;

public class CreateSurveyCommandHandler(IRepository<Survey> repository) : IRequestHandler<CreateSurveyCommand>
{
    public async Task Handle(CreateSurveyCommand request, CancellationToken cancellationToken)
    {
        var survey = request.Adapt<Survey>();
        await repository.Create(survey, cancellationToken);
    }
}