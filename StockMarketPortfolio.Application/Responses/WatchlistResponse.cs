namespace StockMarketPortfolio.Application.Responses
{
    public class WatchlistResponse
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public IList<WatchlistStockResponse> Stocks { get; set; } = default!;
    }
}
