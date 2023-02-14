using AssetManagement.Models;
using EthanFramework.Data.Repository;

namespace AssetManagement.Data.Repositories
{
    public class AssetRepository : BaseEfRepository<Asset, AssetManagementContext>, IAssetRepository
    {
        public AssetRepository(AssetManagementContext context) : base(context)
        {
        }
    }
}
