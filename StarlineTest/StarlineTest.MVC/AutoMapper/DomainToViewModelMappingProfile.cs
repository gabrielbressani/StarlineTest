using AutoMapper;
using StarlineTest.Domain.Entities;
using StarlineTest.MVC.ViewModel;

namespace StarlineTest.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<User, UserViewModel>();
            CreateMap<Question, QuestionViewModel>();
        }
    }
}