namespace StockMarketPortfolio.Application.Exceptions
{
    public class WatchlistNotFoundException : ApplicationException
    {
        public WatchlistNotFoundException(string name, object key) : base($"Entity {name} - {key} not found.")
        {
        }
    }
}
