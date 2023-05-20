using AssetManagement.BC;
using AssetManagement.Dto;
using AssetManagement.Models;
using AutoMapper;
using EthanFramework.WebApi.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetDetailController : AuthEfWebApi<IAssetDetailBC, AssetDetail, AssetDetailDto>
    {
        private readonly IAssetDetailBC _assetDetailBC;
        private readonly IMapper _mapper;
        public AssetDetailController(IMapper mapper, IAssetDetailBC assetDetailBC) : base(mapper, assetDetailBC)
        {
            _assetDetailBC = assetDetailBC;
            _mapper = mapper;
        }

        [HttpGet("AssetAssociation/{id}")]
        public async Task<List<AssetDetailDto>> GetAllDetailsByAssetId(int id)
        {
            var response = await _assetDetailBC.GetAllDetailsByAssetId(id);
            response.Sort((x, y) => x.columnName.CompareTo(y.columnName));
            return _mapper.Map<List<AssetDetailDto>>(response);
        }

        [HttpGet("AssetAssociation/Column/{id}")]
        public async Task<List<string>> GetAllColumnsByType(int id)
        {
            var response = await _assetDetailBC.GetAllColumnsByType(id);
            response.Sort();
            return response;
        }
    }
}
