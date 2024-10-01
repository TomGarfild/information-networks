using Mapster;
using SurveyBuilder.Controllers.Dtos;
using SurveyBuilder.Domain.Commands;
using SurveyBuilder.Domain.Models;

namespace SurveyBuilder.MappingProfiles;

public class SurveyMappingProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreateSurveyDto, CreateSurveyCommand>();

        config.NewConfig<CreateSurveyCommand, Survey>();

        config.NewConfig<Survey, SurveyDto>();
    }
}