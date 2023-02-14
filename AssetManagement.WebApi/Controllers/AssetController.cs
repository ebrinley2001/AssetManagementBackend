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
    public class AssetController : BaseEfWebApi<IAssetBC, Asset, AssetDto>
    {
        public AssetController(IMapper mapper, IAssetBC assetBC) : base(mapper, assetBC)
        {
        }
    }
}
