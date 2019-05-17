using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Options;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using WaldenHospital.API.Helpers;
using WaldenHospital.API.Models;
using WaldenHospital.API.Services;


namespace Walden_Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        //private IUserService _userService;
       
        private IUserService _userService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;


        // GET api/Authentication/login
        [HttpPost("login")]
        public ActionResult<string> Login([FromBody] string name, string password)
        {
            // From Dto
            var user = _userService.Authenticate(name, password);
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Name.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            // return basic user info (without password) and token to store client side
            return Ok(new
            {
                Id = user.ID,
                Username = user.Name,
                Phone = user.Phone,
                Email = user.Email,
                Token = tokenString
            });
        }

        // GET api/Authentication/logout
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            return OK();
        }

        // POST api/Authentication/register
        [HttpPost("register")]
        public void Register([FromBody] string value)
        {
        }
        
    }
}
