namespace StockMarketPortfolio.Application.Responses
{
    public class WatchlistStockResponse
    {
        public string Symbol { get; set; } = string.Empty;
        public string StockName { get; set; } = string.Empty;
        public double CurrentValue { get; set; }
        public double TodayHigh { get; set; }
        public double TodayLow { get; set; }
        public double FiftyTwoWeeksHigh { get; set; }
        public double FiftyTwoWeeksLow { get; set; }
    }
}
