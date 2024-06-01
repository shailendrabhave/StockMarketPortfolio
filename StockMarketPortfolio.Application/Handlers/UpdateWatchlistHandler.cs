using AutoMapper;
using MediatR;
using StockMarketPortfolio.Application.Commands;
using StockMarketPortfolio.Application.Exceptions;
using StockMarketPortfolio.Core.Entities;
using StockMarketPortfolio.Core.Repositories;

namespace StockMarketPortfolio.Application.Handlers
{
    public class UpdateWatchlistHandler : IRequestHandler<UpdateWatchlistCommand>
    {
        private readonly IWatchlistRepository watchlistRepository;
        private readonly IMapper mapper;

        public UpdateWatchlistHandler(IWatchlistRepository watchlistRepository, IMapper mapper)
        {
            this.watchlistRepository = watchlistRepository;
            this.mapper = mapper;
        }
        public async Task Handle(UpdateWatchlistCommand request, CancellationToken cancellationToken)
        {
            var watchlistToUpdate = await watchlistRepository.GetByIdAsync(request.Id);
            if (watchlistToUpdate == null)
            {
                throw new WatchlistNotFoundException(nameof(Watchlist), request.Id);
            }
            mapper.Map(request, watchlistToUpdate, typeof(UpdateWatchlistCommand), typeof(Watchlist));
            await watchlistRepository.UpdateAsync(watchlistToUpdate);
        }
    }
}
