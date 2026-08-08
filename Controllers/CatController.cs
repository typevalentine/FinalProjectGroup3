using Microsoft.AspNetCore.Mvc;
using FinalProjectGroup3.Data;
using FinalProjectGroup3.Models;

namespace FinalProjectGroup3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CatController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get(int? id)
        {
            if (id == null || id == 0)
            {
                return Ok(_context.Cats.Take(5).ToList());
            }

            var cat = _context.Cats.Find(id);
            if (cat == null) return NotFound();

            return Ok(cat);
        }

        [HttpPost]
        public IActionResult Post(Cat cat)
        {
            _context.Cats.Add(cat);
            _context.SaveChanges();
            return Ok(cat);
        }

        [HttpPut]
        public IActionResult Put(Cat cat)
        {
            _context.Cats.Update(cat);
            _context.SaveChanges();
            return Ok(cat);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cat = _context.Cats.Find(id);
            if (cat == null) return NotFound();

            _context.Cats.Remove(cat);
            _context.SaveChanges();
            return Ok();
        }
    }
}