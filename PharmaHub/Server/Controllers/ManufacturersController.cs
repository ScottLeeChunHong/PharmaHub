using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmaHub.Server.Data;
using PharmaHub.Server.IRepository;
using PharmaHub.Shared.Domain;

namespace PharmaHub.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ManufacturersController(IUnitOfWork unitOfWork)
        {
           _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetManufacturers()
        {
            var Manufacturers = await _unitOfWork.Manufacturers.GetAll();
            if (Manufacturers == null)
            {
                return NotFound();
            }
            return Ok(Manufacturers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Manufacturer>> GetManufacturer(int id)
        {
            var Manufacturer = await _unitOfWork.Manufacturers.Get(q => q.Id == id);

            if (Manufacturer == null)
            {
                return NotFound();
            }

            return Ok(Manufacturer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutManufacturer(int id, Manufacturer Manufacturer)
        {
            if (id != Manufacturer.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Manufacturers.Update(Manufacturer);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ManufacturerExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Manufacturer>> PostManufacturer(Manufacturer Manufacturer)
        {
            await _unitOfWork.Manufacturers.Insert(Manufacturer);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetManufacturer", new { id = Manufacturer.Id }, Manufacturer);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteManufacturer(int id)
        {
            var Manufacturer = await _unitOfWork.Manufacturers.Get(q => q.Id == id);
            if (Manufacturer == null)
            {
                return NotFound();
            }

            await _unitOfWork.Manufacturers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ManufacturerExists(int id)
        {
            var Manufacturer = await _unitOfWork.Manufacturers.Get(q => q.Id == id);
            return Manufacturer != null;
        }
    }
}