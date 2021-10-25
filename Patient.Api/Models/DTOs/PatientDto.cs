using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Api.Models.DTOs
{
    public class PatientDto
    {
        public int PatientId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Languages { get; set; }
        public string Address { get; set; }
        public int PinCode { get; set; }
        public int CountryCode { get; set; }
        public string State { get; set; }
        public int ContactNumber { get; set; }
        public int EmergencyContact { get; set; }
        public int NomineeId { get; set; }
        //public DateTime InsertDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
