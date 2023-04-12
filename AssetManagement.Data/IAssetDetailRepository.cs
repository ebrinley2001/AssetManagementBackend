using AssetManagement.Models;
using EthanFramework.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetManagement.Data
{
    public interface IAssetDetailRepository : IBaseEfRepository<AssetDetail>
    {
        public Task<List<AssetDetail>> GetAllDetailsByAssetId(int id);
        public Task<List<string>> GetAllColumnsByType(int id);
    }
}