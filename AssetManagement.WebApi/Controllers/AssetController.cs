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
    public class AssetController : BaseEfWebApi<IAssetBC, Asset, AssetDto>
    {
        private readonly IAssetBC _assetBC;
        private readonly IMapper _mapper;
        public AssetController(IMapper mapper, IAssetBC assetBC) : base(mapper, assetBC)
        {
            _assetBC = assetBC;
            _mapper = mapper;
        }

        [HttpGet("Count/{type}")]
        public async Task<int> GetTypeCount(int type)
        {
            return await _assetBC.GetAssetCount(type);
        }

        [HttpGet("Type/{type}")]
        public async Task<List<AssetDto>> GetAssetsByType(int type)
        {
            var response = await _assetBC.GetAssetsByType(type);
            return _mapper.Map<List<AssetDto>>(response);
        }

        [HttpGet("User/{id}")]
        public async Task<UserDto> GetUserByAssetId(int id)
        {
            var response = await _assetBC.GetUserByAssetId(id);
            return _mapper.Map<UserDto>(response);
        }
    }
}
