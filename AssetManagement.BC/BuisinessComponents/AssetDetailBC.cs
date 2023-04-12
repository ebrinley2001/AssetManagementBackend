using AssetManagement.Data;
using AssetManagement.Models;
using EthanFramework.BC.BuisinessComponents;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetManagement.BC.BuisinessComponents
{
    public class AssetDetailBC : BaseEfBc<AssetDetail, IAssetDetailRepository>, IAssetDetailBC
    {
        private readonly IAssetDetailRepository _assetDetailRepository;
        public AssetDetailBC(IAssetDetailRepository repo) : base(repo)
        {
            _assetDetailRepository = repo;
        }

        public Task<List<AssetDetail>> GetAllDetailsByAssetId(int id)
        {
            return _assetDetailRepository.GetAllDetailsByAssetId(id);
        }

        public Task<List<string>> GetAllColumnsByType(int id)
        {
            return _assetDetailRepository.GetAllColumnsByType(id);
        }

    }
}
