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
    public class AccessLevelController : AuthEfWebApi<IAccessLevelBC, AccessLevel, AccessLevelDto>
    {
        public AccessLevelController(IMapper mapper, IAccessLevelBC accessLevelBC) : base(mapper, accessLevelBC)
        {
        }
    }
}
