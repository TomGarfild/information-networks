using SurveyBuilder.Common;

namespace SurveyBuilder.Controllers.Dtos;

public record QuestionDto
{
    public string Id { get; init; } = Guid.NewGuid().ToString();
    public string Text { get; init; }
    public string SurveyId { get; init; }

    public QuestionType Type { get; init; }

    public IList<QuestionOptionDto> Options { get; init; } = new List<QuestionOptionDto>();
}