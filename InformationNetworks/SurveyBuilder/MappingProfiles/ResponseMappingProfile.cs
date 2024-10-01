using Mapster;
using SurveyBuilder.Controllers.Dtos;
using SurveyBuilder.Domain.Commands;
using SurveyBuilder.Domain.Models;

namespace SurveyBuilder.MappingProfiles;

public class ResponseMappingProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<TakeSurveyDto, CreateResponseCommand>();
        config.NewConfig<(string userId, string questionId, string answer), Response>()
            .Map(x => x.UserId, x => x.userId)
            .Map(x => x.QuestionId, x => x.questionId)
            .Map(x => x.Answer, x => x.answer);
    }
}