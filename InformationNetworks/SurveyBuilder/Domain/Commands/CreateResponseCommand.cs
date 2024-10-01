using MediatR;

namespace SurveyBuilder.Domain.Commands;

public record CreateResponseCommand : IRequest
{
     public string? UserId { get; init; }
     public string SurveyId { get; init; }
     public Dictionary<string, string> Answers { get; init; }
}