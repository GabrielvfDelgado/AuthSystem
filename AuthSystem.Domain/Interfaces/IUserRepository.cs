using AuthSystem.Domain.Entities;
using System.Collections.Generic;

namespace AuthSystem.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAll();
    }
}
