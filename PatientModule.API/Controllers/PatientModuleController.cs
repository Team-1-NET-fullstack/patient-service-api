using Microsoft.AspNetCore.Mvc;
using PatientModule.API.Models;
using PatientModule.API.PatientModule.API.BAL.PatientModule.API.BAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PatientModule.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PatientModuleController : ControllerBase
    {
        private readonly IPateintService<Patient> _pateintService;
        public PatientModuleController(IPateintService<Patient> pateintservice)
        {
            _pateintService = pateintservice;

        }
        // GET: api/<PatientModuleController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return _pateintService.GetAll();
        }

        // GET api/<PatientModuleController>/5
        [HttpGet("{id}")]
        public Patient Get(int id)
        {
            return _pateintService.GetById(id);
        }

        // POST api/<PatientModuleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PatientModuleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PatientModuleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
