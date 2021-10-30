using PatientModule.API.Models;
using PatientModule.API.PatientModule.API.DAL.PatientModule.API.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientModule.API.PatientModule.API.DAL.PatientModule.API.DAL.Implementations
{
    public class PatientVisitRepository : IPatientVisitRepository<PatientVisit>
    {

        private readonly CTGeneralHospitalContext _context;

        public PatientVisitRepository(CTGeneralHospitalContext context)
        {
            _context = context;
        }
        public async Task<PatientVisit> CreateVisit(PatientVisit _object)
        {
            var obj = await _context.AddAsync(_object);
            _context.SaveChanges();
            return obj.Entity;
        }

        public void DeleteVisit(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
        }

        public IEnumerable<PatientVisit> GetAll()
        {
            return _context.PatientVisits.ToList();
        }

        public PatientVisit GetByVisitId(int Id)
        {
            return _context.PatientVisits.Where(s => s.PatientVisitId == Id).FirstOrDefault();
        }

        public Task<PatientVisit> UpdateVisit(PatientVisit _object)
        {
            throw new NotImplementedException();
        }
    }
}
