using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_postgres_example.Models;

namespace dotnet_webapi_postgres_example.Repository
{
    public interface IUserRepository
    {
        /*
        * Cria uma chamada Async
          O task funciona como um tipo de thread pre-alocada pela propria aplicaçao
        */
        List<User> GetUsers();

        User GetUser(int id);

        void AddUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);

        Task<bool> SaveChanges();
        
    }
}