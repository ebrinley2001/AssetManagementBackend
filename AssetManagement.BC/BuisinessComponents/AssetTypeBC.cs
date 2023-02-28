using AssetManagement.Data;
using AssetManagement.Models;
using EthanFramework.BC.BuisinessComponents;

namespace AssetManagement.BC.BuisinessComponents
{
    public class AssetTypeBC : BaseEfBc<AssetType, IAssetTypeRepository>, IAssetTypeBC
    {
        public AssetTypeBC(IAssetTypeRepository repo) : base(repo)
        {
        }
    }
}
