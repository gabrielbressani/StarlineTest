using StarlineTest.Domain.Entities;
using StarlineTest.Domain.Interfaces;
using StarlineTest.Domain.Interfaces.Repositories;
using StarlineTest.Domain.Interfaces.Services;

namespace StarlineTest.Domain.Services
{
    public class QuestionService : ServiceBase<Question>, IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository) 
            : base(questionRepository)
        {
            _questionRepository = questionRepository;
        }
    }
}
