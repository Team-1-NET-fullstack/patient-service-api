using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Api.DAL.IRepository
{
  public  interface IPatientsVisitRepository
    {
        IList<IPatientsVisitRepository> GetPatients();
        public void GetPatient(int id);
        Task<Models.Patient> PostPatient(Models.Patient patientvisits);
        public void DeletePatient(int id);
    }
}
