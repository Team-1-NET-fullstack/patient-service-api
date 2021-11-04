using PatientModule.API.Models;
using PatientModule.API.PatientModule.API.DAL.PatientModule.API.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientModule.API.PatientModule.API.DAL.PatientModule.API.DAL.Implementations
{
    public class AllergyRepository : IAllergyRepository<Allergy>
    {
        private CTGeneralHospitalContext _context;
        public AllergyRepository(CTGeneralHospitalContext context)
        {
            _context = context;
        }

        public async Task<Allergy> CreateAllergy(Allergy _object)
        {
            var obj = await _context.Allergies.AddAsync(_object);
            _context.SaveChanges();
            return obj.Entity;

        }

        public void DeleteAllergy(Allergy _object)
        {
            _context.Remove(_object);
            _context.SaveChanges();
        }

        public IEnumerable<Allergy> GetAllAllergy()
        {
            return _context.Allergies.ToList();
        }

        public Allergy GetByAllergyId(int Id)
        {
            return _context.Allergies.Where(s => s.PatientAllergyId == Id).FirstOrDefault();
        }
    }
}
