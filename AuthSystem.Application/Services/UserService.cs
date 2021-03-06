using AuthSystem.Application.Interfaces;
using AuthSystem.Application.ViewModels;
using AuthSystem.Domain.Entities;
using AuthSystem.Domain.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace AuthSystem.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        
        public List<UserViewModel> Get()
        {
            List<UserViewModel> _userViewModels = new List<UserViewModel>();

            IEnumerable<User> _users = this.userRepository.GetAll();

            _userViewModels = mapper.Map<List<UserViewModel>>(_users);

            //foreach (var item in _users)
            //    _userViewModels.Add(new UserViewModel { Id = item.Id, Email = item.Email, Name = item.Name });


            return _userViewModels;
        }

        public bool Post(UserViewModel userViewModel)
        {

            //User _user = new User
            //{
            //    Id = Guid.NewGuid(),
            //    Email = userViewModel.Email,
            //    Name = userViewModel.Name
            //};

            User _user = mapper.Map<User>(userViewModel);
            this.userRepository.Create(_user);

            return true;
        }
    }
}
