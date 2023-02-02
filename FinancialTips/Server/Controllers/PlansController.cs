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
    public class PlansController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PlansController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Plans
        [HttpGet]
        public async Task<IActionResult> GetPlans()
        {
            var makes = await _unitOfWork.Plans.GetAll();
            return Ok(makes);
        }

        // GET: api/Plans/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlan(int id)
        {
            var Plan = await _unitOfWork.Plans.Get(q => q.Id == id);

            if (Plan == null)
            {
                return NotFound();
            }

            return Ok(Plan);
        }

        // PUT: api/Plans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlan(int id, Plan Plan)
        {
            if (id != Plan.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Plan).State = EntityState.Modified;
            _unitOfWork.Plans.Update(Plan);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PlanExists(id))
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

        // POST: api/Plans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Plan>> PostPlan(Plan Plan)
        {
            // _context.Plans.Add(Plan);
            // await _context.SaveChangesAsync();

            await _unitOfWork.Plans.Insert(Plan);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPlan", new { id = Plan.Id }, Plan);
        }

        // DELETE: api/Plans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlan(int id)
        {
            // var Plan = await _context.Plans.FindAsync(id);
            var Plan = await _unitOfWork.Plans.Get(q => q.Id == id);
            if (Plan == null)
            {
                return NotFound();
            }

            //_context.Plans.Remove(Plan);
            // await _context.SaveChangesAsync();
            await _unitOfWork.Plans.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool PlanExists(int id)
        private async Task<bool> PlanExists(int id)
        {
            var make = await _unitOfWork.Plans.Get(q => q.Id == id);
            return make != null;
        }
    }
}
