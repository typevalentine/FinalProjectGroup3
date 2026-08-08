using Microsoft.AspNetCore.Mvc;

namespace FinalProjectGroup3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TravelDestinationController : ControllerBase
    {
        private readonly ILogger<TravelDestinationController> _logger;

        public TravelDestinationController(ILogger<TravelDestinationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var travelDestinationData = new Models.TravelDestination
            {
                Id = 95432,
                DestinationName = "Berlin",
                Country = "Germany",
                Description = "The capital of Germany, they are known for their nightlife and historical landmarks.",
                BestSeasonToVisit = "Late Spring and Early Summer",
                Rating = 5
            };
            return Ok(travelDestinationData);
        }
    }
}
