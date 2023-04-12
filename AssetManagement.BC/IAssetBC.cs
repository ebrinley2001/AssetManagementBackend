using AssetManagement.Models;
using EthanFramework.BC;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetManagement.BC
{
    public interface IAssetBC : IBaseEfBc<Asset>
    {
        public Task<int> GetAssetCount(int type);
        public Task<List<Asset>> GetAssetsByType(int type);
        public Task<User> GetUserByAssetId(int id);
    }
}
