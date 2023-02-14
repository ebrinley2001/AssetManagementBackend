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
    public class AssetDetailsController : BaseEfWebApi<IAssetDetailBC, AssetDetail, AssetDetailDto>
    {
        public AssetDetailsController(IMapper mapper, IAssetDetailBC assetDetailBC) : base(mapper, assetDetailBC)
        {
        }
    }
}
