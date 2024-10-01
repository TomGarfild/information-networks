namespace SurveyBuilder.Controllers.Dtos;

public record TakeSurveyDto
{
     public string SurveyId { get; init; }
     public Dictionary<string, string> Answers { get; init; }
}