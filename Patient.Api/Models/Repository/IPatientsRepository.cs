using System.Collections.Generic;
using System.Linq;

namespace Patient.Api.Models.Repository
{
    public interface IPatientsRepository
    {
        IList<Patient> GetPatients();
    }
}
