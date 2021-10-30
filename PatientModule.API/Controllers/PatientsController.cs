using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PatientModule.API.Models;
using PatientModule.API.PatientModule.API.BAL.PatientModule.API.BAL.Services;
using PatientModule.API.PatientModule.API.DAL.PatientModule.API.DAL.Interfaces;

namespace PatientModule.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly PatientService  _patientService;

        private readonly IPatientRepository<Patient> _patientRepository;

        public PatientsController(IPatientRepository<Patient> patientRepository, PatientService patientService)
        {
            _patientService = patientService;
            _patientRepository = patientRepository;

        }

        //GET All Note by ID
        [HttpGet("GetPatientById")]
        public Object GetPatientById(int id)
        {
            var data = _patientService.GetPatientById(id);
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }


        //Add Notes  
        [HttpPost("AddPatient")]
        public async Task<Object> AddPatient([FromBody] Patient patient)
        {
            try
            {
                await _patientService.AddPatient(patient);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //Delete Notes  
        [HttpDelete("DeletePatient")]
        public bool DeletePatient(int id)
        {
            try
            {
                _patientService.DeleteVisit(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //GET All Notes  
        [HttpGet("GetAllPatients")]
        public Object GetAllPatients()
        {
            var data = _patientService.GetAllVisits();
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }



    }
}
