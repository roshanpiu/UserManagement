using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementDAL.Entities;

namespace UserManagementDAL.Repositories
{
    public interface IUserRepository
    {
        List<User> Get();
        User Get(int id);
        User Update(User obj);
        User Insert(User obj);
        int Delete(User obj);
    }
}
