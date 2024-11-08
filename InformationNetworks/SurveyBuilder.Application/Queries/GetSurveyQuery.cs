using MediatR;
using SurveyBuilder.Domain.Domain.Models;

namespace SurveyBuilder.Application.Queries;

public record GetSurveyQuery(string Id) : IRequest<Survey?>;