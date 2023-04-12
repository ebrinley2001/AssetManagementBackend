using AssetManagement.Models;
using EthanFramework.Data;
using System.Threading.Tasks;

namespace AssetManagement.Data
{
    public interface IUserRepository : IBaseEfRepository<User>
    {
        public Task<User> getUserByUsernameAsync(string username);
    }
}
