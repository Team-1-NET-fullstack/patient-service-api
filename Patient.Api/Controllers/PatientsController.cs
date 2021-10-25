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
    public class PatientsController : ControllerBase
    {
        private readonly CTGeneralHospitalContext _context;
        private readonly IMapper _mapper;

        public PatientsController(CTGeneralHospitalContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        // GET: api/Patients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Patient>>> GetPatients()
        {
            return await _context.Patients.ToListAsync();
        }

        // GET: api/Patients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Patient>> GetPatient(int id)
        {
            var patient = await _context.Patients.FindAsync(id);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;
        }

        // PUT: api/Patients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatient(int id, [FromBody] Models.DTOs.PatientDto patient)
        {

            var patientToBeEdited = _context.Patients.Find(id);

            if (patientToBeEdited == null)
            {
                return BadRequest();
            }
            patientToBeEdited.Title = patient.Title;
            patientToBeEdited.FirstName = patient.FirstName;
            patientToBeEdited.LastName = patient.LastName;
            patientToBeEdited.Dob = patient.Dob;
            patientToBeEdited.Gender = patient.Gender;
            patientToBeEdited.Race = patient.Race;
            patientToBeEdited.Languages = patient.Languages;
            patientToBeEdited.Address = patient.Address;
            patientToBeEdited.PinCode = patient.PinCode;
            patientToBeEdited.CountryCode = patient.CountryCode;
            patientToBeEdited.State = patient.State;
            patientToBeEdited.ContactNumber = patient.ContactNumber;
            patientToBeEdited.EmergencyContact = patient.EmergencyContact;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientExists(id))
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

        // POST: api/Patients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Models.Patient>> PostPatient(Models.DTOs.PatientDto patient)
        {
            var patientToBeAdded = _mapper.Map<Models.Patient>(patient);
            _context.Patients.Add(patientToBeAdded);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PatientExists(patient.PatientId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPatient", new { id = patient.PatientId }, patient);
        }

        // DELETE: api/Patients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }

            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PatientExists(int id)
        {
            return _context.Patients.Any(e => e.PatientId == id);
        }
    }
}

