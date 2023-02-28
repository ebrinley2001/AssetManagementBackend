using AssetManagement.Data;
using AssetManagement.Models;
using EthanFramework.BC.BuisinessComponents;

namespace AssetManagement.BC.BuisinessComponents
{
    public class AccessLevelBC : BaseEfBc<AccessLevel, IAccessLevelRepository>, IAccessLevelBC
    {
        public AccessLevelBC(IAccessLevelRepository repo) : base(repo)
        {
        }
    }
}
