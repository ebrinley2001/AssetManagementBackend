using AssetManagement.Models;
using EthanFramework.Data.Repository;

namespace AssetManagement.Data.Repositories
{
    public class AccessLevelRepository : BaseEfRepository<AccessLevel, AssetManagementContext>, IAccessLevelRepository
    {
        public AccessLevelRepository(AssetManagementContext context) : base(context)
        {
        }
    }
}
