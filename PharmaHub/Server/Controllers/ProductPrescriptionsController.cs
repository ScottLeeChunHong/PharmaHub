using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmaHub.Server.Data;
using PharmaHub.Shared.Domain;

namespace PharmaHub.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductPrescriptionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductPrescriptionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ProductPrescriptions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductPrescription>>> GetProductPrescriptions()
        {
            if (_context.ProductPrescriptions == null)
            {
                return NotFound();
            }
            return await _context.ProductPrescriptions.ToListAsync();
        }

        // GET: api/ProductPrescriptions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductPrescription>> GetProductPrescription(int id)
        {
            if (_context.ProductPrescriptions == null)
            {
                return NotFound();
            }
            var productPrescription = await _context.ProductPrescriptions.FindAsync(id);

            if (productPrescription == null)
            {
                return NotFound();
            }

            return productPrescription;
        }

        // PUT: api/ProductPrescriptions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductPrescription(int id, ProductPrescription productPrescription)
        {
            if (id != productPrescription.Id)
            {
                return BadRequest();
            }

            _context.Entry(productPrescription).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductPrescriptionExists(id))
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

        // POST: api/ProductPrescriptions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductPrescription>> PostProductPrescription(ProductPrescription productPrescription)
        {
            if (_context.ProductPrescriptions == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ProductPrescriptions'  is null.");
            }
            _context.ProductPrescriptions.Add(productPrescription);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductPrescription", new { id = productPrescription.Id }, productPrescription);
        }

        // DELETE: api/ProductPrescriptions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductPrescription(int id)
        {
            if (_context.ProductPrescriptions == null)
            {
                return NotFound();
            }
            var productPrescription = await _context.ProductPrescriptions.FindAsync(id);
            if (productPrescription == null)
            {
                return NotFound();
            }

            _context.ProductPrescriptions.Remove(productPrescription);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductPrescriptionExists(int id)
        {
            return (_context.ProductPrescriptions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}