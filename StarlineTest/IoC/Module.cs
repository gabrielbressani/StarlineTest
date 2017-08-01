using Ninject;
using StarlineTest.Application;
using StarlineTest.Application.Interface;
using StarlineTest.Domain.Interfaces;
using StarlineTest.Domain.Interfaces.Repositories;
using StarlineTest.Domain.Interfaces.Services;
using StarlineTest.Domain.Services;
using StarlineTest.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public static class Module
    {
        public static void RegisterModules(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IUserAppService>().To<UserAppService>();
            kernel.Bind<IQuestionAppService>().To<QuestionAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<IQuestionService>().To<QuestionService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<IQuestionRepository>().To<QuestionRepository>();
        }
    }
}
