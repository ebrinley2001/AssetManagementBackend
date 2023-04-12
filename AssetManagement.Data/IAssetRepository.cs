using AssetManagement.Models;
using EthanFramework.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetManagement.Data
{
    public interface IAssetRepository : IBaseEfRepository<Asset>
    {
        public Task<int> GetAssetCount(int type);
        public Task<List<Asset>> GetAssetsByType(int type);
        public Task<User> GetUserByAssetId(int id);
    }
}
