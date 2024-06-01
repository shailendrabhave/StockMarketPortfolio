using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockMarketPortfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly ILogger<PortfolioController> logger;

        public PortfolioController(ILogger<PortfolioController> logger)
        {
            this.logger = logger;
        }


    }
}
