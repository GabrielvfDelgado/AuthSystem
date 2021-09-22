using AuthSystem.Domain.Entities;
using AuthSystem.Domain.Interfaces;
using AuthSystem.Infra.Context;
using System.Collections.Generic;

namespace AuthSystem.Infra.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AuthContext context) : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return Query(x => x.IsDeleted == false);
        }
    }
}
