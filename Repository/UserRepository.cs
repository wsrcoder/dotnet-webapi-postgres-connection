using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_postgres_example.Database;
using dotnet_webapi_postgres_example.Models;

namespace dotnet_webapi_postgres_example.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext context;
        public UserRepository(UserContext _context)
        {
            context = _context;
        }

        public void AddUser(User user)
        {
            context.Add(user);
        }

        public void DeleteUser(User user)
        {
            context.Remove(user);
        }

        public User GetUser(int id)
        {
            return context.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public  List<User> GetUsers()
        {
           
            return  context.Users.ToList<User>();

        }

        public async Task<bool> SaveChanges()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public void UpdateUser(User user)
        {
            context.Update(user);
        }
    }
}