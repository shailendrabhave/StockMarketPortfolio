using AutoMapper;
using MediatR;
using StockMarketPortfolio.Application.Queries;
using StockMarketPortfolio.Application.Responses;
using StockMarketPortfolio.Core.Repositories;

namespace StockMarketPortfolio.Application.Handlers
{
    public class GetAllWatchlistsByUserNameHandler : IRequestHandler<GetAllWatchlistsByUserNameQuery, IList<WatchlistResponse>>
    {
        private readonly IWatchlistRepository watchlistRepository;
        private readonly IMapper mapper;

        public GetAllWatchlistsByUserNameHandler(IWatchlistRepository watchlistRepository, IMapper mapper)
        {
            this.watchlistRepository = watchlistRepository;
            this.mapper = mapper;
        }

        public async Task<IList<WatchlistResponse>> Handle(GetAllWatchlistsByUserNameQuery request, CancellationToken cancellationToken)
        {
            var watchlist = await watchlistRepository.GetAllWatchlists(request.UserName);
            var watchlistResponse = mapper.Map<IList<WatchlistResponse>>(watchlist);

            return watchlistResponse;
        }
    }
}
