using MediatR;
using Microsoft.AspNetCore.Mvc;
using StockMarketPortfolio.Application.Commands;
using StockMarketPortfolio.Application.Queries;
using StockMarketPortfolio.Application.Responses;

namespace StockMarketPortfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchlistController : ControllerBase
    {
        private readonly ILogger<WatchlistController> logger;
        private readonly IMediator mediator;

        public WatchlistController(ILogger<WatchlistController> logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllWatchlists")]
        public async Task<ActionResult<IList<WatchlistResponse>>> GetAllWatchlists([FromQuery] GetAllWatchlistsByUserNameQuery query)
        {
            var watchlistResponse = await mediator.Send(query);

            if (watchlistResponse == null)
                return BadRequest();

            return Ok(watchlistResponse);
        }


        [HttpGet]
        [Route("GetWatchlist")]
        public async Task<ActionResult<WatchlistResponse>> GetWatchlist([FromQuery] GetWatchlistQuery query) {
            var watchlistResponse = await mediator.Send(query);

            if (watchlistResponse == null)
                return BadRequest();

            return Ok(watchlistResponse);
        }

        [HttpPost]
        [Route("CreateWatchlist")]
        public async Task<ActionResult<WatchlistResponse>> CreateWatchlist([FromBody] CreateWatchlistCommand createWatchlistCommand)
        {
            var watchlistResponse = await mediator.Send(createWatchlistCommand);

            if (watchlistResponse == null)
                return BadRequest();

            return Created("GetWatchlist", watchlistResponse);
        }

        [HttpPut]
        [Route("UpdateWatchlist")]
        public async Task<ActionResult<WatchlistResponse>> UpdateWatchlist([FromBody] UpdateWatchlistCommand updateWatchlistCommand)
        {
            await mediator.Send(updateWatchlistCommand);
            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteWatchlist")]
        public async Task<ActionResult<WatchlistResponse>> DeleteWatchlist([FromBody] DeleteWatchlistCommand deleteWatchlistCommand)
        {
            await mediator.Send(deleteWatchlistCommand);
            return NoContent();
        }

    }
}
