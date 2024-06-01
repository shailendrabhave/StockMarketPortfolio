using Microsoft.EntityFrameworkCore;
using StockMarketPortfolio.Core.Entities;
using StockMarketPortfolio.Core.Repositories;
using StockMarketPortfolio.Infrastructure.Data;

namespace StockMarketPortfolio.Infrastructure.Repositories
{
    internal class WatchlistRepository: RepositoryBase<Watchlist>, IWatchlistRepository
    {
        private readonly StockMarketDbContext stockMarketDbContext;

        public WatchlistRepository(StockMarketDbContext stockMarketDbContext) : base(stockMarketDbContext)
        {
            this.stockMarketDbContext = stockMarketDbContext;
        }

        public async Task<IList<Watchlist>> GetAllWatchlists(string userName)
        {
            return await stockMarketDbContext.Watchlists
                .Where(x => x.UserName == userName)
                .ToListAsync();
        }

        public async Task<Watchlist> GetWatchlist(string userName, string title)
        {
            return await stockMarketDbContext.Watchlists
                .Include(x => x.Stocks)
                .FirstOrDefaultAsync(x => x.UserName == userName && x.Title == title);
        }
    }
}
