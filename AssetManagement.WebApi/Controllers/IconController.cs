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
    public class IconController : AuthEfWebApi<IIconBC, Icon, IconDto>
    {
        public IconController(IMapper mapper, IIconBC iconBC) : base(mapper, iconBC)
        {
        }
    }
}
