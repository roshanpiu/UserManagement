using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementDAL.Entities;
using UserManagementDAL.Repositories;

namespace UserManagementDAL
{
    public interface IUserService
    {
        UserRepository Users { get; }
    }
}
