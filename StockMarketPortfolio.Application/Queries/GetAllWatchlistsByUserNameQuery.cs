using MediatR;
using StockMarketPortfolio.Application.Responses;

namespace StockMarketPortfolio.Application.Queries
{
    public class GetAllWatchlistsByUserNameQuery:IRequest<IList<WatchlistResponse>>
    {
        public string UserName { get; set; } = string.Empty;
    }
}
