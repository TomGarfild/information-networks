namespace SurveyBuilder.Controllers.Dtos;

public record CreateSurveyDto
{
    public string Id { get; init; } = Guid.NewGuid().ToString();
    public string Title { get; init; }

    public string? Description { get; init; }

    public bool IsPublished { get; init; } = false;

    public IList<QuestionDto> Questions { get; set; } = new List<QuestionDto>();
}