using AssetManagement.Models;
using EthanFramework.Data.Repository;

namespace AssetManagement.Data.Repositories
{
    public class AssetTypeRepository : BaseEfRepository<AssetType, AssetManagementContext>, IAssetTypeRepository
    {
        public AssetTypeRepository(AssetManagementContext context) : base(context)
        {
        }
    }
}
