using AssetManagement.Models;
using EthanFramework.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Data.Repositories
{
    public class AssetRepository : BaseEfRepository<Asset, AssetManagementContext>, IAssetRepository
    {
        private readonly AssetManagementContext _context;
        public AssetRepository(AssetManagementContext context) : base(context)
        {
            _context = context;
        }

        public Task<int> GetAssetCount(int type)
        {
            return _context.Set<Asset>().Where(o => o.type == type).CountAsync();
        }

        public Task<List<Asset>> GetAssetsByType(int type)
        {
            return _context.Set<Asset>().Where(o => o.type == type).ToListAsync();
        }

        public Task<User> GetUserByAssetId(int id)
        {
            return _context.Set<Asset>().Where(x => x.id == id).Include(x => x.User).Select(x => x.User).FirstAsync();
        }
    }
}
