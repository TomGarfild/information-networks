using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveyBuilder.Domain.Domain.Models;

public class Response : IHasId
{
    [Key] public string Id { get; init; } = Guid.NewGuid().ToString();

    [Required]
    public string QuestionId { get; init; }

    [ForeignKey("QuestionId")]
    public Question Question { get; init; }

    public required string Answer { get; init; }

    public required string? UserId { get; init; }

    [ForeignKey("UserId")]
    public ApplicationUser User { get; init; }

    [DataType(DataType.DateTime)]
    public DateTime ResponseDate { get; init; } = DateTime.UtcNow;
}