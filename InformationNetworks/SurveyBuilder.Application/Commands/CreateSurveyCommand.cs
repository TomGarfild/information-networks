using MediatR;
using SurveyBuilder.Domain.Domain.Models;

namespace SurveyBuilder.Application.Commands;

public record CreateSurveyCommand : IRequest
{
    public required string Id { get; init; }
    public string? UserId { get; init; }
    
    public required string Title { get; init; }

    public string? Description { get; init; }

    public bool IsPublished { get; init; } = false;

    public ICollection<Question> Questions { get; init; }
}