namespace SurveyBuilder.Controllers.Dtos;

public record SurveyDto
{
    public required string Id { get; init; }

    public required string Title { get; init; }

    public string? Description { get; init; }

    public bool IsPublished { get; init; } = false;

    public ICollection<QuestionDto> Questions { get; init; }
}