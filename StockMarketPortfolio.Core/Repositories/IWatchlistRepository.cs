using StockMarketPortfolio.Core.Entities;

namespace StockMarketPortfolio.Core.Repositories
{
    public interface IWatchlistRepository:IAsyncRepository<Watchlist>
    {
        public Task<IList<Watchlist>> GetAllWatchlists(string userName);
        public Task<Watchlist> GetWatchlist(string userName, string title);
    }
}
