using Patient.Api.DAL.IRepository;
using Patient.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Api.DAL.Implementation
{
    public class PatientRepository : IPatientsRepository
    {
        private CTGeneralHospitalContext context;
        public PatientRepository(CTGeneralHospitalContext _context)
        {
            context = _context;
        }
        public IList<Models.Patient> GetPatients()
        {
            return context.Patients.ToList();
        }
        public Models.Patient GetPatient(int id)
        {
            return context.Patients.Where(s => s.PatientId == id).FirstOrDefault();

            //  return context.Patients.Where(x.Id == Id).FirstOrDefault();
            throw new NotImplementedException();
        }

        public void PutPatient(int id, Models.Patient obj)
        {
            throw new NotImplementedException();
        }
        public void DeletePatient(int id)
        {
            context.Remove(id);
            context.SaveChanges();

        }

        //void IPatientsRepository.GetPatient(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //async Task<Models.Patient> IPatientsRepository.PutPatient(Models.Patient patient)
        //{
        //    var obj = await context.Patients.AddAsync(patient);
        //    context.SaveChanges();
        //    return obj.Entity;
        //}

        public async Task<Models.Patient> PostPatient(Models.Patient _object)
        {
            var obj = await context.Patients.AddAsync(_object);
            context.SaveChanges();
            return obj.Entity;
        }

        IList<IPatientsRepository> IPatientsRepository.GetPatients()
        {
            throw new NotImplementedException();
        }

        void IPatientsRepository.GetPatient(int id)
        {
            throw new NotImplementedException();
        }

        Task<Models.Patient> IPatientsRepository.PostPatient(Models.Patient patient)
        {
            throw new NotImplementedException();
        }

        void IPatientsRepository.DeletePatient(int id)
        {
            throw new NotImplementedException();
        }
    }
}
