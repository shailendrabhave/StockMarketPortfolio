using AutoMapper;
using MediatR;
using StockMarketPortfolio.Application.Commands;
using StockMarketPortfolio.Application.Responses;
using StockMarketPortfolio.Core.Entities;
using StockMarketPortfolio.Core.Repositories;

namespace StockMarketPortfolio.Application.Handlers
{
    public class CreateWatchlistHandler : IRequestHandler<CreateWatchlistCommand, WatchlistResponse>
    {
        private readonly IWatchlistRepository watchlistRepository;
        private readonly IMapper mapper;

        public CreateWatchlistHandler(IWatchlistRepository watchlistRepository, IMapper mapper)
        {
            this.watchlistRepository = watchlistRepository;
            this.mapper = mapper;
        }

        public async Task<WatchlistResponse> Handle(CreateWatchlistCommand request, CancellationToken cancellationToken)
        {
            var watchlistEntity = mapper.Map<Watchlist>(request);
            var newWatchlist = await watchlistRepository.AddAsync(watchlistEntity);
            return mapper.Map<WatchlistResponse>(newWatchlist);
        }
    }
}
