﻿using AssetManagement.BC;
using AssetManagement.Dto;
using AssetManagement.Models;
using AutoMapper;
using EthanFramework.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetTypeController : BaseEfWebApi<IAssetTypeBC, AssetType, AssetTypeDto>
    {
        public AssetTypeController(IMapper mapper, IAssetTypeBC assetTypeBC) : base(mapper, assetTypeBC)
        {
        }
    }
}
