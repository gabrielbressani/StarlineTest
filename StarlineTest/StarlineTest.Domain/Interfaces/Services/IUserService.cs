using StarlineTest.Domain.Entities;
using System.Collections.Generic;

namespace StarlineTest.Domain.Interfaces.Services
{
    public interface IUserService : IServiceBase<User>
    {
        IEnumerable<User> GetActivesForThisYear(IEnumerable<User> users);
    }
}
