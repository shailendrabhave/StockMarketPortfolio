using AutoMapper;
using StockMarketPortfolio.Application.Commands;
using StockMarketPortfolio.Application.Responses;
using StockMarketPortfolio.Core.Entities;

namespace StockMarketPortfolio.Application.Mappers
{
    public class StockMarketMappingProfiles:Profile
    {
        public StockMarketMappingProfiles()
        {
            CreateMap<Watchlist, CreateWatchlistCommand>().ReverseMap();
            CreateMap<Watchlist, UpdateWatchlistCommand>().ReverseMap();
            CreateMap<WatchlistStock, WatchlistStockResponse>().ReverseMap();
            CreateMap<Watchlist, WatchlistResponse>().ReverseMap();
        }
    }
}
