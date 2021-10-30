using PatientModule.API.Models;
using PatientModule.API.PatientModule.API.DAL.PatientModule.API.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientModule.API.PatientModule.API.DAL.PatientModule.API.DAL.Implementations
{
    public class PatientRepository: IPatientRepository<Patient>
    {
        private readonly CTGeneralHospitalContext _context;
        public PatientRepository(CTGeneralHospitalContext context)
        {
            _context = context;
        }

        public async Task<Patient> Create(Patient _object)
        {
            var obj = await _context.Patients.AddAsync(_object);
            _context.SaveChanges();
            return obj.Entity;
        }

        public void Delete(Patient _object)
        {
            _context.Remove(_object);
            _context.SaveChanges();
        }

        public IEnumerable<Patient> GetAll()
        {
            return _context.Patients.ToList();
        }

        public Patient GetById(int id)
        {
            return _context.Patients.Where(s => s.PatientId == id).FirstOrDefault();
        }

        public Task<Patient> Update(Patient _object)
        {
            throw new NotImplementedException();
        }
    }
}
