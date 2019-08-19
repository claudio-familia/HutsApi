using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HutsApi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace HutsApi.Controllers
{
    public class UsersController : Controller
    {
        private readonly IConfiguration _configuration;
        public UsersController(IConfiguration iConfiguration)
        {
            _configuration = iConfiguration;
        }
        // POST: api/Users/Authenticate
        [HttpPost("Authenticate")]
        public IActionResult Post([FromBody] UserDevice model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Generate JWT for the device.
            var token = new JwtSecurityTokenHandler().WriteToken(GenerateJwt(model.IMEI));
            return Ok(token);
        }

        private JwtSecurityToken GenerateJwt(string imei)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, imei)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "turealdominio.com",
                audience: "turealdominio.com",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return token;

        }


    }
}