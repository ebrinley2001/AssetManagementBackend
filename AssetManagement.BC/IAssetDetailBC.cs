using AssetManagement.Models;
using EthanFramework.BC;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AssetManagement.BC
{
    public interface IAssetDetailBC : IBaseEfBc<AssetDetail>
    {
        public Task<List<AssetDetail>> GetAllDetailsByAssetId(int id);
        public Task<List<string>> GetAllColumnsByType(int id);
    }
}
