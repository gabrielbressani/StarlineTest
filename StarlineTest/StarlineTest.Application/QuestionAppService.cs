using StarlineTest.Application.Interface;
using StarlineTest.Domain.Entities;
using StarlineTest.Domain.Interfaces.Services;

namespace StarlineTest.Application
{
    public class QuestionAppService : AppServiceBase<Question>, IQuestionAppService
    {
        private readonly IQuestionService _questionService;

        public QuestionAppService(IQuestionService questionService) 
            : base(questionService)
        {
            _questionService = questionService;
        }
    }
}
