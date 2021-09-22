using AuthSystem.Application.ViewModels;
using System.Collections.Generic;

namespace AuthSystem.Application.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get();
    }
}
