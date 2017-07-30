using StarlineTest.Domain.Entities;
using StarlineTest.Domain.Interfaces;

namespace StarlineTest.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
    }
}
