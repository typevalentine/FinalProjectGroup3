using Microsoft.AspNetCore.Mvc;
using FinalProjectGroup3.Data;
using FinalProjectGroup3.Models;

namespace FinalProjectGroup3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TravelDestinationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TravelDestinationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(int? id)
        {
            if (id == null || id == 0)
            {
                return Ok(_context.TravelDestinations.Take(5).ToList());
            }

            var destination = _context.TravelDestinations.Find(id);
            if (destination == null) return NotFound();

            return Ok(destination);
        }

        [HttpPost]
        public IActionResult Post(TravelDestination destination)
        {
            _context.TravelDestinations.Add(destination);
            _context.SaveChanges();
            return Ok(destination);
        }

        [HttpPut]
        public IActionResult Put(TravelDestination destination)
        {
            _context.TravelDestinations.Update(destination);
            _context.SaveChanges();
            return Ok(destination);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var destination = _context.TravelDestinations.Find(id);
            if (destination == null) return NotFound();

            _context.TravelDestinations.Remove(destination);
            _context.SaveChanges();
            return Ok();
        }
    }
}