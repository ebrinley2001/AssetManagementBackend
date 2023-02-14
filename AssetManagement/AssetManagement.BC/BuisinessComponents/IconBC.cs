using AssetManagement.Data;
using AssetManagement.Models;
using EthanFramework.BC.BuisinessComponents;

namespace AssetManagement.BC.BuisinessComponents
{
    public class IconBC : BaseEfBc<Icon, IIconRepository>, IIconBC
    {
        public IconBC(IIconRepository repo) : base(repo)
        {
        }
    }
}
