using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Api.Models.Repository
{
    public class PatientRepository : IPatientsRepository
    {
        private CTGeneralHospitalContext context;
        public PatientRepository(CTGeneralHospitalContext _context)
        {
            context = _context;
        }
        public IList<Patient> GetPatients()
        {
            return context.Patients.ToList();
        }
    }
}
