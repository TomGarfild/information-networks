using Mapster;
using MediatR;
using SurveyBuilder.Application.Commands;
using SurveyBuilder.Data.Repositories;
using SurveyBuilder.Domain.Domain.Models;

namespace SurveyBuilder.Application.CommandHandlers;

public class CreateResponseCommandHandler(IRepository<Response> repository) : IRequestHandler<CreateResponseCommand>
{
    public async Task Handle(CreateResponseCommand request, CancellationToken cancellationToken)
    {
        foreach (var response in request.Answers.Select(answer =>
                     (request.UserId, answer.Key, answer.Value).Adapt<Response>()))
        {
            await repository.Create(response, cancellationToken);
        }
    }
}