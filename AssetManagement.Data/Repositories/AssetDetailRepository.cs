using AssetManagement.Models;
using EthanFramework.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Data.Repositories
{
    public class AssetDetailRepository : BaseEfRepository<AssetDetail, AssetManagementContext>, IAssetDetailRepository
    {
        private readonly AssetManagementContext _context;
        public AssetDetailRepository(AssetManagementContext context) : base(context)
        {
            _context = context;
        }

        public Task<List<AssetDetail>> GetAllDetailsByAssetId(int id)
        {
            return _context.Set<AssetDetail>().Where(o => o.assetAssociation == id).ToListAsync();
        }

        public Task<List<string>> GetAllColumnsByType(int id)
        {
            return _context.Set<AssetDetail>().Include(x => x.Asset).Where(x => x.Asset.AssetType.id == id).Select(x => x.columnName).Distinct().ToListAsync();
        }
    }
}
