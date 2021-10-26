using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Patient.Api.Models;

namespace Patient.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientVisitsController : ControllerBase
    {
        private readonly CTGeneralHospitalContext _context;
        private readonly IMapper _mapper;


        public PatientVisitsController(CTGeneralHospitalContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/PatientVisits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientVisit>>> GetPatientVisits()
        {
            return await _context.PatientVisits.ToListAsync();
        }

        // GET: api/PatientVisits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PatientVisit>> GetPatientVisit(int id)
        {
            var patientVisit = await _context.PatientVisits.FindAsync(id);

            if (patientVisit == null)
            {
                return NotFound();
            }

            return patientVisit;
        }
        /*
         *  public async Task<IActionResult> PutPatient(int id, [FromBody] Models.DTOs.PatientDto patient)
        {
            var patientToBeEdited = _context.Patients.Find(id);

            if (patientToBeEdited == null)
            {
                return BadRequest();
            }
            patientToBeEdited.Title = patient.Title;
         */
        // PUT: api/PatientVisits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
            public async Task<IActionResult> PutPatientVisit(int id, [FromBody]Models.DTOs.PatientVisitDto patientVisit)
        {
            var patientVisitToBeEdited = _context.PatientVisits.Find(id);
            if (patientVisitToBeEdited == null)
            {
                return BadRequest();
            }
            patientVisitToBeEdited.Reason = patientVisit.Reason;
            patientVisitToBeEdited.StartTime = patientVisit.StartTime;
            patientVisitToBeEdited.Duration = patientVisit.Duration;
            patientVisitToBeEdited.VisitDate = patientVisit.VisitDate;
            patientVisitToBeEdited.DiagnosisDescription = patientVisit.DiagnosisDescription;
            patientVisitToBeEdited.MedicationDescription = patientVisit.MedicationDescription;
            patientVisitToBeEdited.ProcedureDescription = patientVisit.ProcedureDescription;
            patientVisitToBeEdited.AllergyDescription = patientVisit.AllergyDescription;
            patientVisitToBeEdited.CreatedBy = patientVisit.CreatedBy;
            patientVisitToBeEdited.CreatedDate = patientVisit.CreatedDate;
            patientVisitToBeEdited.UpdatedBy = patientVisit.UpdatedBy;
            patientVisitToBeEdited.UpdatedDate = patientVisit.UpdatedDate;
            patientVisitToBeEdited.PatientId = patientVisit.PatientId;
            patientVisitToBeEdited.PhysicianId = patientVisit.PhysicianId;

            // _context.Entry(patientVisit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientVisitExists(id))
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

        // POST: api/PatientVisits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        /*
         *    public async Task<ActionResult<Models.Patient>> PostPatient(Models.DTOs.PatientDto patient)
        {
            var patientToBeAdded = _mapper.Map<Models.Patient>(patient);
            _context.Patients.Add(patientToBeAdded);
         */
        public async Task<ActionResult<Models.PatientVisit>> PostPatientVisit(Models.DTOs.PatientVisitDto patientVisit)
        {
            var patientVisitToBeAdded = _mapper.Map<Models.PatientVisit>(patientVisit);
            _context.PatientVisits.Add(patientVisitToBeAdded);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PatientVisitExists(patientVisit.PatientVisitId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPatientVisit", new { id = patientVisit.PatientVisitId }, patientVisit);
        }

        // DELETE: api/PatientVisits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatientVisit(int id)
        {
            var patientVisit = await _context.PatientVisits.FindAsync(id);
            if (patientVisit == null)
            {
                return NotFound();
            }

            _context.PatientVisits.Remove(patientVisit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PatientVisitExists(int id)
        {
            return _context.PatientVisits.Any(e => e.PatientVisitId == id);
        }
    }
}
