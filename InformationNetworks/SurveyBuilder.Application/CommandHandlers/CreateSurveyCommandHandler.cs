using Mapster;
using MediatR;
using SurveyBuilder.Application.Commands;
using SurveyBuilder.Data.Repositories;
using SurveyBuilder.Domain.Domain.Models;

namespace SurveyBuilder.Application.CommandHandlers;

public class CreateSurveyCommandHandler(IRepository<Survey> repository) : IRequestHandler<CreateSurveyCommand>
{
    public async Task Handle(CreateSurveyCommand request, CancellationToken cancellationToken)
    {
        var survey = request.Adapt<Survey>();
        await repository.Create(survey, cancellationToken);
    }
}