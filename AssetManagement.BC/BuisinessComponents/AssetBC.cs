using AssetManagement.Data;
using AssetManagement.Models;
using EthanFramework.BC.BuisinessComponents;

namespace AssetManagement.BC.BuisinessComponents
{
    public class AssetBC : BaseEfBc<Asset, IAssetRepository>, IAssetBC
    {
        public AssetBC(IAssetRepository repo) : base(repo)
        {
        }
    }
}
