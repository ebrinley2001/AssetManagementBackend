using AssetManagement.Data;
using AssetManagement.Models;
using EthanFramework.BC.BuisinessComponents;

namespace AssetManagement.BC.BuisinessComponents
{
    public class UserBC : BaseEfBc<User, IUserRepository>, IUserBC
    {
        public UserBC(IUserRepository repo) : base(repo)
        {
        }
    }
}
