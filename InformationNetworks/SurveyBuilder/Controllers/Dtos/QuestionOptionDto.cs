using SurveyBuilder.Common;
using SurveyBuilder.Domain.Models;

namespace SurveyBuilder.Controllers.Dtos;

public record QuestionOptionDto
{
    public string QuestionId { get; set; }

    public string OptionText { get; set; }
}