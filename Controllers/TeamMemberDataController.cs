using Microsoft.AspNetCore.Mvc;
using FinalProjectGroup3.Data;
using FinalProjectGroup3.Models;

namespace FinalProjectGroup3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamMemberDataController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TeamMemberDataController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(int? id)
        {
            if (id == null || id == 0)
            {
                return Ok(_context.TeamMemberData.Take(5).ToList());
            }

            var member = _context.TeamMemberData.Find(id);
            if (member == null) return NotFound();

            return Ok(member);
        }

        [HttpPost]
        public IActionResult Post(TeamMemberData member)
        {
            _context.TeamMemberData.Add(member);
            _context.SaveChanges();
            return Ok(member);
        }

        [HttpPut]
        public IActionResult Put(TeamMemberData member)
        {
            _context.TeamMemberData.Update(member);
            _context.SaveChanges();
            return Ok(member);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var member = _context.TeamMemberData.Find(id);
            if (member == null) return NotFound();

            _context.TeamMemberData.Remove(member);
            _context.SaveChanges();
            return Ok();
        }
    }
}