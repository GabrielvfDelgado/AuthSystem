using AuthSystem.Application.ViewModels;
using AuthSystem.Domain.Entities;
using AutoMapper;

namespace AuthSystem.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain

            CreateMap<UserViewModel, User>();

            #endregion

            #region DomainToViewModel

            CreateMap<User, UserViewModel>();

            #endregion

        }
    }
}
