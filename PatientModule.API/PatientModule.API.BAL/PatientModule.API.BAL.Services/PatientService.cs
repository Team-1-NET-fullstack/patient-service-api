using PatientModule.API.Models;
using PatientModule.API.PatientModule.API.DAL.PatientModule.API.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientModule.API.PatientModule.API.BAL.PatientModule.API.BAL.Services
{
    public class PatientService
    {
        private readonly IPatientRepository<Patient> _patientRepository;
        public PatientService(IPatientRepository<Patient> patientRepository)
        {
            _patientRepository = patientRepository;

        }

        //GET All Note Details   
        public IEnumerable<Patient> GetAllVisits()
        {
            try
            {
                return (IEnumerable<Patient>)_patientRepository.GetAll().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Get Notes By Id  
        public IEnumerable<Patient> GetPatientById(int id)
        {
            return _patientRepository.GetAll().Where(x => x.PatientId == id).ToList();
        }

        //Add Note
        public async Task<Patient> AddPatient(Patient patient)
        {
            return await _patientRepository.Create(patient);
        }
        //Delete Note   
        public bool DeleteVisit(int id)
        {
            try
            {
                var DataList = _patientRepository.GetAll().Where(x => x.PatientId == id).ToList();
                foreach (var item in DataList)
                {
                    _patientRepository.Delete(item);
                }
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }


    }
}
