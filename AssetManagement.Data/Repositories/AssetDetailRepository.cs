using AssetManagement.Models;
using EthanFramework.Data.Repository;

namespace AssetManagement.Data.Repositories
{
    public class AssetDetailRepository : BaseEfRepository<AssetDetail, AssetManagementContext>, IAssetDetailRepository
    {
        public AssetDetailRepository(AssetManagementContext context) : base(context)
        {
        }
    }
}
