using MediatR;
using StockMarketPortfolio.Application.Commands;
using StockMarketPortfolio.Application.Exceptions;
using StockMarketPortfolio.Core.Entities;
using StockMarketPortfolio.Core.Repositories;

namespace StockMarketPortfolio.Application.Handlers
{
    public class DeleteWatchlistHandler : IRequestHandler<DeleteWatchlistCommand>
    {
        private readonly IWatchlistRepository watchlistRepository;

        public DeleteWatchlistHandler(IWatchlistRepository watchlistRepository)
        {
            this.watchlistRepository = watchlistRepository;
        }
        public async Task Handle(DeleteWatchlistCommand request, CancellationToken cancellationToken)
        {
            var watchlistToDelete = await watchlistRepository.GetByIdAsync(request.Id);
            if (watchlistToDelete == null)
            {
                throw new WatchlistNotFoundException(nameof(Watchlist), request.Id);
            }
            await watchlistRepository.DeleteAsync(watchlistToDelete);
        }
    }
}
