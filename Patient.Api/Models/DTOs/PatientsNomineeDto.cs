using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Api.Models.DTOs
{
    public class PatientsNomineeDto
    {
        public int NomineeId { get; set; }
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Relationship { get; set; }
        public int ContactNumber { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool HasAccess { get; set; }
        public string NomineeAddress { get; set; }
    }
}
