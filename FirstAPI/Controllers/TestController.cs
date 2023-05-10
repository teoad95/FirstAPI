using FirstAPI.Data;
using FirstAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public List<User> GetUsers()
        {
            return DB.Users;
        }

        [HttpGet("{id:int}")]
        public User? GetUser(int id)
        {
            return DB.Users.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public User? CreateUser(string name)
        {
            var id = DB.Users.Max(x => x.Id) + 1;
            var newUser = new User() { Id = id, Name = name };
            DB.Users.Add(newUser);
            return newUser;
        }
    }
}
