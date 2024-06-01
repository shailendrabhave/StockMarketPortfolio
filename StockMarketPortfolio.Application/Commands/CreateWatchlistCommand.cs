using MediatR;
using StockMarketPortfolio.Application.Responses;

namespace StockMarketPortfolio.Application.Commands
{
    public class CreateWatchlistCommand: IRequest<WatchlistResponse>
    {
        public string UserName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}
