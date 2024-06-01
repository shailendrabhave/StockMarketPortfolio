using MediatR;

namespace StockMarketPortfolio.Application.Commands
{
    public class DeleteWatchlistCommand:IRequest
    {
        public int Id { get; set; } 
    }
}
