using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo_List.Core.Entities;
using ToDo_List.Services.Interfaces;

namespace ToDo_List.Api.Controllers
{
   // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("GetAllUsers")]
        public List<User> Get()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = _userService.GetUserById(id);
            return user;
        }

        //[HttpPost]
        //public void Post([FromBody] User user)
        //{
        //    try
        //    {

        //        _userService.CreateUser(user);
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
       
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            if (user == null || user.Id == 0)
                throw new Exception("Invalid User");
            _userService.UpdateUser(user);
        }
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            if (id == 0)
                throw new Exception("Invalid User Id");
            return _userService.DeleteUser(id);
        }
    }
}
