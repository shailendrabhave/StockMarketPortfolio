using MediatR;

namespace StockMarketPortfolio.Application.Commands
{
    public class UpdateWatchlistCommand:IRequest
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}
