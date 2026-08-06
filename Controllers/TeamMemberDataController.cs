using Microsoft.AspNetCore.Mvc;

namespace FinalProjectGroup3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMemberDataController : ControllerBase
    {
        private readonly ILogger<TeamMemberDataController> _logger;

        public TeamMemberDataController(ILogger<TeamMemberDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public IActionResult Get()
        {
            var teamMemberData = new Models.TeamMemberData
            {
                FullName = "Valentine Miller",
                Birthdate = new DateTime(2006, 1, 11),
                CollegeProgram = "Information Technology",
                YearInProgram = 3,
                Hobby = "Drawing"
            };
            return Ok(teamMemberData);
        }
    }
}
