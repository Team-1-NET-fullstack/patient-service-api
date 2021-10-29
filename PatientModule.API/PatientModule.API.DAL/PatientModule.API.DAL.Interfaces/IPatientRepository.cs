using PatientModule.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientModule.API.PatientModule.API.DAL.PatientModule.API.DAL.Interfaces
{
    public interface IPatientRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
    }
}
