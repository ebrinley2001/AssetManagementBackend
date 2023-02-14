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
    public class IconController : BaseEfWebApi<IIconBC, Icon, IconDto>
    {
        public IconController(IMapper mapper, IIconBC iconBC) : base(mapper, iconBC)
        {
        }
    }
}
