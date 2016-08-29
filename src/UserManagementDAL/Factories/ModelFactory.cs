using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementDAL.Entities;
using UserManagementDTO;

namespace UserManagementDAL.Factories
{
    public class ModelFactory : IModelFactory
    {
        public User Create(UserModel user)
        {
            if (user.Id == 0)
            {
                return new User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Username = user.Username,
                    Email = user.Email,
                    DateOfBirth = user.DateOfBirth,
                    Password = user.Password
                };
            }
            return new User
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Email = user.Email,
                DateOfBirth = user.DateOfBirth,
                Password = user.Password
            };
        }

        public UserModel Create(User user)
        {
            return new UserModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Email = user.Email,
                DateOfBirth = user.DateOfBirth,
                Password = user.Password
            };
        }
    }
}
