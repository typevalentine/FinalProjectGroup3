using Microsoft.AspNetCore.Mvc;

namespace FinalProjectGroup3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoGameController : ControllerBase
    {
        private readonly ILogger<VideoGameController> _logger;

        public VideoGameController(ILogger<VideoGameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public IActionResult Get()
        {
            var videoGameData = new Models.VideoGame
            {
                Id = 34821,
                Title = "Outer Wilds",
                Engine = "Unity",
                ReleaseYear = 2019,
                IsMultiplayer = false
            };
            return Ok(videoGameData);
        }
    }
}
