using StarlineTest.Domain.Entities;
using StarlineTest.Domain.Interfaces.Repositories;

namespace StarlineTest.Infra.Data.Repositories
{
    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
    }
}
