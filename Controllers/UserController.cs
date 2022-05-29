using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_postgres_example.Models;
using dotnet_webapi_postgres_example.Repository;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_webapi_postgres_example.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")] //define a rota do endpoint que será, nesse caso, api/User

    
    public class UserController:ControllerBase
    {
        private static List<User>? users;
        private readonly IUserRepository repository;
        

        public UserController(IUserRepository _repository)
        {
                
                repository = _repository;
                
                users = new List<User>();

                User user = new User();

                user.Id = 1;
                user.Name = "Lucas";
                user.Birthday = new DateTime(1990,5,10);
                users.Add(user);

                //outra maneira de adicionar um dado a uma lista
                users.Add( new User{Id = 2, Name = "Pedro", Birthday = DateTime.Parse("04/07/1993")});
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = repository.GetUsers();
            return users.Any()?Ok(users):NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = repository.GetUser(id);
            return user!= null? Ok(user):NotFound("Usuário não encontrado");
        }

        [HttpPost]
        public async Task<IActionResult> AddUserAsync(User user)
        {

            repository.AddUser(user);

            return await repository.SaveChanges()? Ok("Usuario salvo com sucesso"): BadRequest("Erro ao salvar o Usuário");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(User user)
        {
            var _user = repository.GetUser(user.Id);

            if(_user == null)
            {
                return NotFound("Usuario não encontrado");
            }

            _user.Name = user.Name;
            _user.Birthday = user.Birthday;

            repository.UpdateUser(_user);

            return await repository.SaveChanges()?Ok("Usuario atualizado"):BadRequest("Erro ao atualizar usuário");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var _user = repository.GetUser(id);
            if(_user == null)
            {
                return NotFound("Usuário não encontrado");
            }

            repository.DeleteUser(_user);

            return await repository.SaveChanges()?Ok("Usuário apagado"): BadRequest("Erro ao apagar usuário");
        }
    }
}