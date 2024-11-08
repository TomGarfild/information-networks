using System.ComponentModel.DataAnnotations;

namespace SurveyBuilder.Domain.Domain.Models;

public class Survey : IHasId
{
    [Key] public string Id { get; init; } = Guid.NewGuid().ToString();

    [Required]
    [StringLength(200)]
    public required string Title { get; init; }

    public string? Description { get; init; }

    public bool IsPublished { get; init; } = false;

    [DataType(DataType.DateTime)]
    public DateTime CreatedDate { get; init; } = DateTime.UtcNow;

    [DataType(DataType.DateTime)]
    public DateTime? PublishedDate { get; init; }

    public ICollection<Question> Questions { get; init; }
}
