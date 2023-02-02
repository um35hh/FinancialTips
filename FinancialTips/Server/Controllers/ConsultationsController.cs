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
    public class ConsultationsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ConsultationsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Consultations
        [HttpGet]
        public async Task<IActionResult> GetConsultations()
        {
            var makes = await _unitOfWork.Consultations.GetAll();
            return Ok(makes);
        }

        // GET: api/Consultations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConsultation(int id)
        {
            var Consultation = await _unitOfWork.Consultations.Get(q => q.Id == id);

            if (Consultation == null)
            {
                return NotFound();
            }

            return Ok(Consultation);
        }

        // PUT: api/Consultations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultation(int id, Consultation Consultation)
        {
            if (id != Consultation.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Consultation).State = EntityState.Modified;
            _unitOfWork.Consultations.Update(Consultation);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ConsultationExists(id))
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

        // POST: api/Consultations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Consultation>> PostConsultation(Consultation Consultation)
        {
            // _context.Consultations.Add(Consultation);
            // await _context.SaveChangesAsync();

            await _unitOfWork.Consultations.Insert(Consultation);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetConsultation", new { id = Consultation.Id }, Consultation);
        }

        // DELETE: api/Consultations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsultation(int id)
        {
            // var Consultation = await _context.Consultations.FindAsync(id);
            var Consultation = await _unitOfWork.Consultations.Get(q => q.Id == id);
            if (Consultation == null)
            {
                return NotFound();
            }

            //_context.Consultations.Remove(Consultation);
            // await _context.SaveChangesAsync();
            await _unitOfWork.Consultations.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool ConsultationExists(int id)
        private async Task<bool> ConsultationExists(int id)
        {
            var make = await _unitOfWork.Consultations.Get(q => q.Id == id);
            return make != null;
        }
    }
}
