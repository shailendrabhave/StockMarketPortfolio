using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockMarketPortfolio.Core.Repositories;
using StockMarketPortfolio.Infrastructure.Data;
using StockMarketPortfolio.Infrastructure.Repositories;

namespace StockMarketPortfolio.Infrastructure.Extensions
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfraServices(
            this IServiceCollection serviceCollection,
            IConfiguration configuration)
        {
            serviceCollection.AddDbContext<StockMarketDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("StockPortfolioConnectionString"));
            });
            serviceCollection.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            serviceCollection.AddScoped<IWatchlistRepository, WatchlistRepository>();
            serviceCollection.AddScoped<ITransactionRepository, TransactionRepository>();
            return serviceCollection;
        }
    }
}
