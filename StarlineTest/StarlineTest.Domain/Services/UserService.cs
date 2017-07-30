using System;
using System.Collections.Generic;
using StarlineTest.Domain.Entities;
using StarlineTest.Domain.Interfaces;
using StarlineTest.Domain.Interfaces.Services;
using System.Linq;

namespace StarlineTest.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) 
            : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetActivesForThisYear(IEnumerable<User> users)
        {
            return users.Where(u => u.UserActiveOfThisYear(u));
        }
    }
}
