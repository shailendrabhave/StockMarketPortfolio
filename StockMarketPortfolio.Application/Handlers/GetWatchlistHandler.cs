using AutoMapper;
using MediatR;
using StockMarketPortfolio.Application.Queries;
using StockMarketPortfolio.Application.Responses;
using StockMarketPortfolio.Core.Repositories;

namespace StockMarketPortfolio.Application.Handlers
{
    public class GetWatchlistHandler : IRequestHandler<GetWatchlistQuery, WatchlistResponse>
    {
        private readonly IWatchlistRepository watchlistRepository;
        private readonly IMapper mapper;

        public GetWatchlistHandler(IWatchlistRepository watchlistRepository, IMapper mapper)
        {
            this.watchlistRepository = watchlistRepository;
            this.mapper = mapper;
        }

        public async Task<WatchlistResponse> Handle(GetWatchlistQuery request, CancellationToken cancellationToken)
        {
            var watchlist = await watchlistRepository.GetWatchlist(request.UserName, request.Title);
            var watchlistResponse = mapper.Map<WatchlistResponse>(watchlist);

            return watchlistResponse;
        }
    }
}
