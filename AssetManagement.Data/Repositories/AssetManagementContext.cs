using AssetManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data.Repositories
{
    public class AssetManagementContext : DbContext
    {
        public DbSet<AssetDetail> AssetDetails { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<User> Users { get; set; }

        public AssetManagementContext(DbContextOptions<AssetManagementContext> options) : base(options)
        {
        }
    }
}
