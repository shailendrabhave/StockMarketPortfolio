using Microsoft.EntityFrameworkCore;
using StockMarketPortfolio.Core.Entities;

namespace StockMarketPortfolio.Infrastructure.Data
{
    public class StockMarketDbContext : DbContext
    {
        public StockMarketDbContext(DbContextOptions<StockMarketDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=StockMarketDb;User Id=sa;Password=sa;TrustServerCertificate=True;");
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<EntityBase>())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.Entity.ModifiedOn = DateTime.Now;
                        entry.Entity.ModifiedBy = "Shailendra";  //TODO: To be replaced by Identity Server
                        break;
                    case EntityState.Added:
                        entry.Entity.CreatedOn = DateTime.Now;
                        entry.Entity.CreatedBy = "Shailendra";  //TODO: To be replaced by Identity Server
                        break;
                    default:
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Watchlist> Watchlists { get; set; }
        public DbSet<WatchlistStock> WatchlistStocks { get; set; }
    }
}
