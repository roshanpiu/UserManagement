using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementDAL.Entities;
using UserManagementDAL.Repositories;

namespace UserManagementDAL
{
    public class UserService : IUserService
    {
        private UserRepository _users;

        public UserRepository Users
        {
            get
            {
                if (_users == null)
                    _users = new UserRepository(new UserDbContext());

                return _users;
            }
        }
    }
}
