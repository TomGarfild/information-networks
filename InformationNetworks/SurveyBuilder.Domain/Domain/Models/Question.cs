using System.ComponentModel.DataAnnotations;
using SurveyBuilder.Domain.Common;

namespace SurveyBuilder.Domain.Domain.Models;

public class Question : IHasId
{
    [Key] public string Id { get; init; } = Guid.NewGuid().ToString();

    [Required]
    public string SurveyId { get; set; }

    public Survey Survey { get; set; }

    [Required]
    [StringLength(500)]
    public string Text { get; set; }

    [Required]
    public QuestionType Type { get; set; }

    public ICollection<QuestionOption> Options { get; set; }

    public ICollection<Response> Responses { get; set; }
}