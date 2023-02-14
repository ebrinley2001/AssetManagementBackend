using AssetManagement.Models;
using EthanFramework.Data.Repository;

namespace AssetManagement.Data.Repositories
{
    public class IconRepository : BaseEfRepository<Icon, AssetManagementContext>, IIconRepository
    {
        public IconRepository(AssetManagementContext context) : base(context)
        {
        }
    }
}
