using AssetManagement.Data;
using AssetManagement.Models;
using EthanFramework.BC.BuisinessComponents;

namespace AssetManagement.BC.BuisinessComponents
{
    public class AssetDetailBC : BaseEfBc<AssetDetail, IAssetDetailRepository>, IAssetDetailBC
    {
        public AssetDetailBC(IAssetDetailRepository repo) : base(repo)
        {
        }
    }
}
