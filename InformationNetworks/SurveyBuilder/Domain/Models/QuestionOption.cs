using System.ComponentModel.DataAnnotations;

namespace SurveyBuilder.Domain.Models;

public class QuestionOption : IHasId
{
    [Key] public string Id { get; init; } = Guid.NewGuid().ToString();

    [Required]
    public string QuestionId { get; set; }

    public Question Question { get; set; }

    [Required]
    public string OptionText { get; set; }

    public bool IsCorrect { get; set; } = false;
}