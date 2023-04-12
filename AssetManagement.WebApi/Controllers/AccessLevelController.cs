using AssetManagement.BC;
using AssetManagement.Dto;
using AssetManagement.Models;
using AutoMapper;
using EthanFramework.WebApi.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.WebApi.Controllers
{
    [Authorize(Roles = "2")]
    [Route("api/[controller]")]
    [ApiController]
    public class AccessLevelController : BaseEfWebApi<IAccessLevelBC, AccessLevel, AccessLevelDto>
    {
        public AccessLevelController(IMapper mapper, IAccessLevelBC accessLevelBC) : base(mapper, accessLevelBC)
        {
        }
    }
}
