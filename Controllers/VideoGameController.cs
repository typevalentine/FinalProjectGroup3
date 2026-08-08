using Microsoft.AspNetCore.Mvc;
using FinalProjectGroup3.Data;
using FinalProjectGroup3.Models;

namespace FinalProjectGroup3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoGameController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VideoGameController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(int? id)
        {
            if (id == null || id == 0)
            {
                return Ok(_context.VideoGames.Take(5).ToList());
            }

            var game = _context.VideoGames.Find(id);
            if (game == null) return NotFound();

            return Ok(game);
        }

        [HttpPost]
        public IActionResult Post(VideoGame game)
        {
            _context.VideoGames.Add(game);
            _context.SaveChanges();
            return Ok(game);
        }

        [HttpPut]
        public IActionResult Put(VideoGame game)
        {
            _context.VideoGames.Update(game);
            _context.SaveChanges();
            return Ok(game);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var game = _context.VideoGames.Find(id);
            if (game == null) return NotFound();

            _context.VideoGames.Remove(game);
            _context.SaveChanges();
            return Ok();
        }
    }
}