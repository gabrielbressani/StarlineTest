using StarlineTest.Application.Interface;
using StarlineTest.Domain.Entities;
using System.Collections.Generic;
using StarlineTest.Domain.Interfaces.Services;

namespace StarlineTest.Application
{
    public class UserAppService : AppServiceBase<User>, IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService) 
            : base(userService)
        {
            _userService = userService;
        }

        public IEnumerable<User> GetActivesForThisYear()
        {
            return _userService.GetActivesForThisYear(_userService.GetAll());
        }
    }
}
