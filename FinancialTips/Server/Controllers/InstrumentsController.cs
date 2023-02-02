using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinancialTips.Server.Data;
using FinancialTips.Shared.Domain;
using FinancialTips.Server.IRepository;

namespace FinancialTips.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public InstrumentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Instruments
        [HttpGet]
        public async Task<IActionResult> GetInstruments()
        {
            var makes = await _unitOfWork.Instruments.GetAll();
            return Ok(makes);
        }

        // GET: api/Instruments/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInstrument(int id)
        {
            var instrument = await _unitOfWork.Instruments.Get(q => q.Id == id);

            if (instrument == null)
            {
                return NotFound();
            }

            return Ok(instrument); 
        }

        // PUT: api/Instruments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstrument(int id, Instrument instrument)
        {
            if (id != instrument.Id)
            {
                return BadRequest();
            }

            //_context.Entry(instrument).State = EntityState.Modified;
            _unitOfWork.Instruments.Update(instrument);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await InstrumentExists(id))
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

        // POST: api/Instruments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Instrument>> PostInstrument(Instrument instrument)
        {
            // _context.Instruments.Add(instrument);
            // await _context.SaveChangesAsync();

            await _unitOfWork.Instruments.Insert(instrument);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetInstrument", new { id = instrument.Id }, instrument);
        }

        // DELETE: api/Instruments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstrument(int id)
        {
            // var instrument = await _context.Instruments.FindAsync(id);
            var instrument = await _unitOfWork.Instruments.Get(q => q.Id == id);
            if (instrument == null)
            {
                return NotFound();
            }

            //_context.Instruments.Remove(instrument);
            // await _context.SaveChangesAsync();
            await _unitOfWork.Instruments.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool InstrumentExists(int id)
        private async Task<bool> InstrumentExists(int id)
        {
            var make = await _unitOfWork.Instruments.Get(q => q.Id == id);
            return make != null;
        }
    }
}
