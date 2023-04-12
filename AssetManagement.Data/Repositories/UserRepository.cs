using AssetManagement.Models;
using EthanFramework.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Data.Repositories
{
    public class UserRepository : BaseEfRepository<User, AssetManagementContext>, IUserRepository
    {
        private readonly AssetManagementContext _context;
        public UserRepository(AssetManagementContext context) : base(context)
        {
            _context = context;
        }

        public Task<User> getUserByUsernameAsync(string username)
        {
            return _context.Set<User>().Where(x => x.userName == username).FirstAsync();
        }
    }
}
