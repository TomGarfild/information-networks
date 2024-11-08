using MediatR;
using SurveyBuilder.Domain.Domain.Models;

namespace SurveyBuilder.Application.Queries;

public class GetAllSurveysQuery : IRequest<ICollection<Survey>>
{
    
}