using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementDAL.Entities;
using UserManagementDTO;

namespace UserManagementDAL.Factories
{
    public interface IModelFactory
    {
        UserModel Create(User user);
        User Create(UserModel user);
    }
}
