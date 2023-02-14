using AssetManagement.BC;
using AssetManagement.Dto;
using AssetManagement.Models;
using AutoMapper;
using EthanFramework.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseEfWebApi<IUserBC, User, UserDto>
    {
        public UserController(IMapper mapper, IUserBC userBc) : base(mapper, userBc)
        {
        }
    }
}
