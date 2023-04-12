using AssetManagement.Models;
using AssetManagement.Models.HelperModels;
using EthanFramework.BC;
using System.Threading.Tasks;

namespace AssetManagement.BC
{
    public interface IUserBC : IBaseEfBc<User>
    {
        public Task<User?> Login(Login loginDetails);
    }
}
