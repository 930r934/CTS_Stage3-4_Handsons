using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticeCheckForCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        // GET api/<AuthController>/5
        [HttpGet("generatetoken/{id}")]
        public string Get(int id)
        {
            string role;
            if (id == 1)
                role = "Admin";
            else if (id == -1)
                role = null;
            else
                role = "Customer";
            
            return GenerateJSONWebToken(id, role);
        }

        private string GenerateJSONWebToken(int userId, string userRole)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mysuperdupersecret"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
       
            var claims = new List<Claim>
                {
                new Claim(ClaimTypes.Role, userRole),
                new Claim("UserId", userId.ToString())
                };

            var token = new JwtSecurityToken(
                                                issuer: "mySystem",
                                                audience: "myUsers",
                                                claims: claims,
                                                expires: DateTime.Now.AddMinutes(10),
                                                signingCredentials: credentials
                                                
                                                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
