using Mapster;
using SurveyBuilder.Controllers.Dtos;
using SurveyBuilder.Domain.Domain.Models;

namespace SurveyBuilder.MappingProfiles;

public class QuestionMappingProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Question, QuestionDto>();
    }
}