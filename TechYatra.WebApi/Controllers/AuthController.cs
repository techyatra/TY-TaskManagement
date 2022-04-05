using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ToDo_List.Core.Entities;
using ToDo_List.Infrastructure.Context;
using ToDo_List.Services.Interfaces;

namespace ToDo_List.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public User SignUp([FromBody] User user)
        {
            if (String.IsNullOrEmpty(user.Name))
                throw new Exception("name can not be empty or null");
            if (String.IsNullOrEmpty(user.UserName))
                throw new Exception("username can not be empty or null");
            var existingUser = _userService.GetUserByUserName(user.UserName);
            if (existingUser != null)
                throw new Exception("userName already exists, please add unique userName");
            var existingUserByEmail = _userService.GetUserByEmail(user.Email);
            if (existingUserByEmail != null)
                throw new Exception("email already exists in the database");
            var existingUserByPhone = _userService.GetUserByPhone(user.Mobile);
            if (existingUserByPhone != null)
                throw new Exception("user already exists with phone number");
            _userService.CreateUser(user);
            return user;

        }


        [HttpGet("signin/{username}/{password}")]
        public User SignIn(string username, string password)
        {
            var user = _userService.GetUserByUserName(username);
            if (user != null && user.Password == password)
                return user;
            else if (user != null && user.Password != password)
                throw new Exception("invalid credentials");
            var userByPhone = _userService.GetUserByPhone(username);
            if (userByPhone != null && userByPhone.Password == password)
                return userByPhone;
            else if (userByPhone != null && userByPhone.Password != password)
                throw new Exception("invalid credentials");
            var userByEmail = _userService.GetUserByEmail(username);
            if (userByEmail != null && userByEmail.Password == password)
                return userByEmail;
            else if (userByEmail != null && userByEmail.Password != password)
                throw new Exception("invalid credentials");
            else
                throw new Exception("user not found");

        }
        [HttpGet("resetPassword/{username}/password")]
        public User ResetPassword(string username, string password)
        {
            var user = _userService.ResetPassword(username, password);
            return user;
                
        }


            //[HttpPost]
            //public async Task<IActionResult> Post(User _userData)
            //{
            //    if (_userData != null && _userData.Email != null && _userData.Password != null)
            //    {
            //        var user = await GetUser(_userData.Email, _userData.Password);

            //        if (user != null)
            //        {
            //            //create claims details based on the user information
            //            var claims = new[] {
            //                new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
            //                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            //                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
            //                new Claim("UserId", user.Id.ToString()),
            //                //new Claim("DisplayName", user.DisplayName),
            //                new Claim("UserName", user.UserName),
            //                new Claim("Email", user.Email)
            //            };

            //            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            //            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            //            var token = new JwtSecurityToken(
            //                _configuration["Jwt:Issuer"],
            //                _configuration["Jwt:Audience"],
            //                claims,
            //                expires: DateTime.UtcNow.AddMinutes(10),
            //                signingCredentials: signIn);

            //            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            //        }
            //        else
            //        {
            //            return BadRequest("Invalid credentials");
            //        }
            //    }
            //    else
            //    {
            //        return BadRequest();
            //    }
            //}

            //private async Task<User> GetUser(string email, string password)
            //{
            //    return await _context.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
            //}


        }

    public class ForgotPasswordViewModel
    {
        public object Email { get; internal set; }
    }
}
