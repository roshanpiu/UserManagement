using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementDAL.Entities;

namespace UserManagementDAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public int Delete(User obj)
        {
            try
            {
                _context.Users.Remove(obj);
                return _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public List<User> Get()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public User Get(int id)
        {
            try
            {
                return _context.Users.Single( x => x.Id == id);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public User Insert(User obj)
        {
            try
            {
                _context.Users.Add(obj);
                var result = _context.SaveChanges();
                return obj;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public User Update(User obj)
        {
            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();

                return obj;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
