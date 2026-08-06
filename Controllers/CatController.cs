using Microsoft.AspNetCore.Mvc;

namespace FinalProjectGroup3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatController : ControllerBase
    {
        private readonly ILogger<CatController> _logger;

        public CatController(ILogger<CatController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        
        public IActionResult Get()
        {
            var catData = new Models.Cat
            {
                Id = 2506,
                Name = "Victoria",
                Age = 10,
                HasAutoFeeder = true,
                FurColor = "Black"
            };
            return Ok(catData);
        }
    }
}
