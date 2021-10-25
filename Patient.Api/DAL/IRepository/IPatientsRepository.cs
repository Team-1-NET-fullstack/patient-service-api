using Patient.Api.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Api.DAL.IRepository
{
    public interface IPatientsRepository
    {
        IList<IPatientsRepository> GetPatients();
        public void GetPatient(int id);
        Task<Models.Patient> PostPatient(Models.Patient patient);
        public void DeletePatient(int id);
    }
}
