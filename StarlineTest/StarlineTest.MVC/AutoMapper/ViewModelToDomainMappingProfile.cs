using AutoMapper;
using StarlineTest.Domain.Entities;
using StarlineTest.MVC.ViewModel;

namespace StarlineTest.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserViewModel, User>();
            CreateMap<QuestionViewModel, Question>();
        }
    }
}