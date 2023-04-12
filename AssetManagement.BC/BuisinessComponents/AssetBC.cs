using AssetManagement.Data;
using AssetManagement.Models;
using EthanFramework.BC.BuisinessComponents;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetManagement.BC.BuisinessComponents
{
    public class AssetBC : BaseEfBc<Asset, IAssetRepository>, IAssetBC
    {
        private readonly IAssetRepository _assetRepository;
        public AssetBC(IAssetRepository repo) : base(repo)
        {
            _assetRepository = repo;
        }

        public Task<int> GetAssetCount(int type)
        {
            return _assetRepository.GetAssetCount(type);
        }

        public Task<List<Asset>> GetAssetsByType(int type)
        {
            return _assetRepository.GetAssetsByType(type);
        }

        public Task<User> GetUserByAssetId(int id)
        {
            return _assetRepository.GetUserByAssetId(id);
        }
    }
}
