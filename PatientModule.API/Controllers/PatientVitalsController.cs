using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PatientModule.API.Models;
using PatientModule.API.PatientModule.API.BAL;
using PatientModule.API.PatientModule.API.BAL.PatientModule.API.BAL.Services;
using PatientModule.API.PatientModule.API.DAL.PatientModule.API.DAL.Interfaces;

namespace PatientModule.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientVitalsController : ControllerBase
    {
        private readonly PatientVitalService _patientVitalService;

        private readonly IPatientVitalRepository<PatientVital> _patientVitalRepository;

        public PatientVitalsController(PatientVitalService patientVitalService, IPatientVitalRepository<PatientVital> patientVitalRepository)
        {
            _patientVitalService = patientVitalService;
            _patientVitalRepository = patientVitalRepository;

        }
        // GET: api/PatientVitals
        [HttpGet]
        public Object GetAllVitals()
        {
            var data = _patientVitalService.GetAllVitals();
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }
        // GET: api/PatientVitals/5
        [HttpGet("{id}")]
        public Object GetVitalsById(int id)
        {
            var data = _patientVitalRepository.GetByVitalId(id);
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }

        // PUT: api/PatientVitals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        //public async Task<IActionResult> PutPatientVital(int id, PatientVital patientVital)
        //{
        //    if (id != patientVital.PatientVitalId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(patientVital).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PatientVitalExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/PatientVitals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<Object> AddVitals([FromBody] PatientVital patientVital)
        {
            try
            {
                await _patientVitalService.AddVital(patientVital);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        // DELETE: api/PatientVitals/5
        [HttpDelete("{id}")]
        public bool DeleteVitals(int id)
        {
            try
            {
                _patientVitalService.DeleteVital(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       
    }
}
