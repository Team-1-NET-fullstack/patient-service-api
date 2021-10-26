using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patient.Api.Models;

namespace Patient.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientVitalsController : ControllerBase
    {
        private readonly CTGeneralHospitalContext _context;

        public PatientVitalsController(CTGeneralHospitalContext context)
        {
            _context = context;
        }

        // GET: api/PatientVitals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientVital>>> GetPatientVitals()
        {
            return await _context.PatientVitals.ToListAsync();
        }

        // GET: api/PatientVitals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PatientVital>> GetPatientVital(int id)
        {
            var patientVital = await _context.PatientVitals.FindAsync(id);

            if (patientVital == null)
            {
                return NotFound();
            }

            return patientVital;
        }

        // PUT: api/PatientVitals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatientVital(int id, PatientVital patientVital)
        {
            if (id != patientVital.PatientVitalId)
            {
                return BadRequest();
            }

            _context.Entry(patientVital).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientVitalExists(id))
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

        // POST: api/PatientVitals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PatientVital>> PostPatientVital(PatientVital patientVital)
        {
            _context.PatientVitals.Add(patientVital);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PatientVitalExists(patientVital.PatientVitalId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPatientVital", new { id = patientVital.PatientVitalId }, patientVital);
        }

        // DELETE: api/PatientVitals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatientVital(int id)
        {
            var patientVital = await _context.PatientVitals.FindAsync(id);
            if (patientVital == null)
            {
                return NotFound();
            }

            _context.PatientVitals.Remove(patientVital);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PatientVitalExists(int id)
        {
            return _context.PatientVitals.Any(e => e.PatientVitalId == id);
        }
    }
}
