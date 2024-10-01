using MediatR;
using SurveyBuilder.Domain.Models;

namespace SurveyBuilder.Domain.Queries;

public record GetSurveyQuery(string Id) : IRequest<Survey?>
{
    
}