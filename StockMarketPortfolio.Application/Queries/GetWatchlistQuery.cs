using MediatR;
using StockMarketPortfolio.Application.Responses;

namespace StockMarketPortfolio.Application.Queries
{
    public class GetWatchlistQuery : IRequest<WatchlistResponse>
    {
        public string UserName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}
