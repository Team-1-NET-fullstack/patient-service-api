using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patient.Api.DAL.IRepository;
using Patient.Api.Models;
namespace Patient.Api.DAL.Implementation
{
    public class PatientVisitRepository : IPatientsVisitRepository
    {
        private CTGeneralHospitalContext context;
        public PatientVisitRepository(CTGeneralHospitalContext _context)
        {
                context = _context;   
        }
        public void DeletePatient(int id)
        {
            context.Remove(id);
            context.SaveChanges();
        }

        public PatientVisit GetPatient(int id)
        {
            return context.PatientVisits.Where(s => s.PatientId == id).FirstOrDefault();
        }
        public IList<IPatientsVisitRepository> GetPatients()
        {
            return (IList<IPatientsVisitRepository>)context.PatientVisits.ToList();
        }

        public async Task<Models.PatientVisit> PostPatient(Models.PatientVisit _object)
        {
            var obj = await context.PatientVisits.AddAsync(_object);
            context.SaveChanges();
            return obj.Entity;
        }

        public Task<Models.Patient> PostPatient(Models.Patient patientvisits)
        {
            throw new NotImplementedException();
        }

        void IPatientsVisitRepository.GetPatient(int id)
        {
            throw new NotImplementedException();
        }
        /*
*  public Models.Patient GetPatient(int id)
{
   return context.Patients.Where(s => s.PatientId == id).FirstOrDefault();

   //  return context.Patients.Where(x.Id == Id).FirstOrDefault();
   throw new NotImplementedException();
}
*/


        //    void IPatientsVisitRepository.GetPatient(int id)
        //    {

        //            return context.PatientVists.Where(s => s.PatientId == id).FirstOrDefault();

        //}
    }
}
