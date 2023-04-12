using AssetManagement.BC;
using AssetManagement.Dto;
using AssetManagement.Models;
using AssetManagement.Models.HelperModels;
using AssetManagement.WebApi.Helpers;
using AutoMapper;
using EthanFramework.WebApi.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AssetManagement.WebApi.Controllers
{
    [Authorize(Roles = "2")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseEfWebApi<IUserBC, User, UserDto>
    {
        private readonly IUserBC _userBC;
        private readonly JwtDetails _jwtDetails;
        public UserController(IMapper mapper, IUserBC userBc, IOptions<JwtDetails> jwtDetails) : base(mapper, userBc)
        {
            _userBC = userBc;
            _jwtDetails = jwtDetails.Value;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<string> Login([FromBody] Login loginDetails)
        {
            var user = await _userBC.Login(loginDetails);
            if (user != null)
            {
                return user.CreateToken(_jwtDetails);
            }
            return StatusCodes.Status401Unauthorized.ToString();
        }
    }
}
