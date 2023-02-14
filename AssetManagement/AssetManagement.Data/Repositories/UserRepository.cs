using AssetManagement.Models;
using EthanFramework.Data.Repository;

namespace AssetManagement.Data.Repositories
{
    public class UserRepository : BaseEfRepository<User, AssetManagementContext>, IUserRepository
    {
        public UserRepository(AssetManagementContext context) : base(context)
        {
        }
    }
}
