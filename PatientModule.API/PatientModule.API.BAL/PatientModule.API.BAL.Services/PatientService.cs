using PatientModule.API.Models;
using PatientModule.API.PatientModule.API.BAL.PatientModule.API.BAL.Interfaces;
using PatientModule.API.PatientModule.API.DAL.PatientModule.API.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientModule.API.PatientModule.API.BAL.PatientModule.API.BAL.Services
{
    public class PatientService: IPateintService<Patient>
    {
        private readonly IPatientRepository<Patient> _patientRepository;
        public PatientService(IPatientRepository<Patient> patientRepository)
        {
            _patientRepository = patientRepository;

        }

        public IEnumerable<Patient> GetAll()
        {
            return _patientRepository.GetAll();
        }

        public Patient GetById(int id)
        {
            return _patientRepository.GetById(id);
        }
    }
}
