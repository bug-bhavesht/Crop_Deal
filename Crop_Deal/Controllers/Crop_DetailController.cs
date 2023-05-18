using Crop_Deal.Context;
using Crop_Deal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crop_Deal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Crop_DetailController : ControllerBase
    {
        private readonly CD_DbContext _context;

        public Crop_DetailController(CD_DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Crop_Details>>> GetCrop_details()
        {
            if (_context.Crop_Detail == null)
            {
                return NotFound();
            }
            return await _context.Crop_Detail.ToListAsync();
        }

        // GET: api/Crop_detail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Crop_Details>> GetCrop_detail(int id)
        {
            if (_context.Crop_Detail == null)
            {
                return NotFound();
            }
            var crop_detail = await _context.Crop_Detail.FindAsync(id);

            if (crop_detail == null)
            {
                return NotFound();
            }

            return crop_detail;
        }

        // PUT: api/Crop_detail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCrop_detail(int id, Crop_Details crop_detail)
        {
            if (id != crop_detail.CropDetail_Id)
            {
                return BadRequest();
            }

            _context.Entry(crop_detail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Crop_detailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Crop_detail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Crop_Details>> PostCrop_detail(Crop_Details crop_detail)
        {
            if (_context.Crop_Detail == null)
            {
                return Problem("Entity set 'ApiDbContext.Crop_details'  is null.");
            }
            _context.Crop_Detail.Add(crop_detail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCrop_detail", new { id = crop_detail.CropDetail_Id }, crop_detail);
        }

        // DELETE: api/Crop_detail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCrop_detail(int id)
        {
            if (_context.Crop_Detail == null)
            {
                return NotFound();
            }
            var crop_detail = await _context.Crop_Detail.FindAsync(id);
            if (crop_detail == null)
            {
                return NotFound();
            }

            _context.Crop_Detail.Remove(crop_detail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Crop_detailExists(int id)
        {
            return (_context.Crop_Detail?.Any(e => e.CropDetail_Id == id)).GetValueOrDefault();
        }
    }
}
