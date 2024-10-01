using MediatR;
using SurveyBuilder.Domain.Models;

namespace SurveyBuilder.Domain.Queries;

public class GetAllSurveysQuery : IRequest<ICollection<Survey>>
{
    
}