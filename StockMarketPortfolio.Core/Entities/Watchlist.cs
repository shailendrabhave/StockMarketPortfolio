namespace StockMarketPortfolio.Core.Entities
{
    public class Watchlist : EntityBase
    {
        public string Title { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public IList<WatchlistStock> Stocks { get; set; } = default!;
    }
}
