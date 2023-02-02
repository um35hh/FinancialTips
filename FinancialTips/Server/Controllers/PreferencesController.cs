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
    public class PreferencesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PreferencesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Preferences
        [HttpGet]
        public async Task<IActionResult> GetPreferences()
        {
            var makes = await _unitOfWork.Preferences.GetAll();
            return Ok(makes);
        }

        // GET: api/Preferences/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPreference(int id)
        {
            var Preference = await _unitOfWork.Preferences.Get(q => q.Id == id);

            if (Preference == null)
            {
                return NotFound();
            }

            return Ok(Preference);
        }

        // PUT: api/Preferences/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPreference(int id, Preference Preference)
        {
            if (id != Preference.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Preference).State = EntityState.Modified;
            _unitOfWork.Preferences.Update(Preference);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PreferenceExists(id))
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

        // POST: api/Preferences
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Preference>> PostPreference(Preference Preference)
        {
            // _context.Preferences.Add(Preference);
            // await _context.SaveChangesAsync();

            await _unitOfWork.Preferences.Insert(Preference);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPreference", new { id = Preference.Id }, Preference);
        }

        // DELETE: api/Preferences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePreference(int id)
        {
            // var Preference = await _context.Preferences.FindAsync(id);
            var Preference = await _unitOfWork.Preferences.Get(q => q.Id == id);
            if (Preference == null)
            {
                return NotFound();
            }

            //_context.Preferences.Remove(Preference);
            // await _context.SaveChangesAsync();
            await _unitOfWork.Preferences.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool PreferenceExists(int id)
        private async Task<bool> PreferenceExists(int id)
        {
            var make = await _unitOfWork.Preferences.Get(q => q.Id == id);
            return make != null;
        }
    }
}
