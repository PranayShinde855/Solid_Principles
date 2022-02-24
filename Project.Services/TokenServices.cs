using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Project.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Project.Services
{
    public interface ITokenServices
    {
        string CreateToken(UserLogin obj);
    }

    public class TokenServices : ITokenServices
    {
        private readonly SymmetricSecurityKey _key;
        public TokenServices(IConfiguration config)
        {
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWT:TokenKey"]));
        }

        public string CreateToken(UserLogin obj)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.NameId, obj.UserName)
            };
            var cred = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(2),
                SigningCredentials = cred
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
