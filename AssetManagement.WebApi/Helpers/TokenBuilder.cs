using AssetManagement.Models;
using AssetManagement.Models.HelperModels;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AssetManagement.WebApi.Helpers
{
    public static class TokenBuilder
    {
        public static string CreateToken(this User user, JwtDetails jwtDetails)
        {
            var key = Encoding.ASCII.GetBytes(jwtDetails.Key);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim("Id", Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.userName),
                new Claim(ClaimTypes.Role, user.permissionLevel.ToString())
             }),
                Expires = DateTime.UtcNow.AddHours(3),
                Issuer = jwtDetails.Issuer,
                Audience = jwtDetails.Audience,
                SigningCredentials = new SigningCredentials (new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }
    }
}
