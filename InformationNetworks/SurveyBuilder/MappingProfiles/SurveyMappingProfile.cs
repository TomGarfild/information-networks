using Mapster;
using SurveyBuilder.Application.Commands;
using SurveyBuilder.Controllers.Dtos;
using SurveyBuilder.Domain.Domain.Models;

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