using AspNetCore;
using Laboratorium8.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Laboratorium8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserManager<IdentityUser> _user;
        private IConfiguration _configuration;
        public UserController(UserManager<IdentityUser> userManager, IConfiguration Configuration) {
            _user = userManager;
            _configuration = Configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Token([FromBody] UserDto dto)
        {
            var user = await _user.FindByEmailAsync(dto.UserName);
            var result = await _user.CheckPasswordAsync(user, dto.Password);
            if (result)
            {
                var claims = new List<Claim>(){
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                };
                var key = new SymmetricSecurityKey( Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    issuer: _configuration["Tokens:Issuer"],
                    audience: _configuration["Tokens:Audience"],
                    claims: claims,
                    expires: DateTime.UtcNow.AddMinutes(60),
                    signingCredentials: creds
                );
                return Ok(
                    new {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo
                    }
                );
            }
            else
            {
                return BadRequest("Login Failure");
            }
        }
    }
}
