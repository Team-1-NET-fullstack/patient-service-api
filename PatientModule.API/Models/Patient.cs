using System;
using System.Collections.Generic;

#nullable disable

namespace PatientModule.API.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Appointments = new HashSet<Appointment>();
            Diagnoses = new HashSet<Diagnosis>();
            PatientVisits = new HashSet<PatientVisit>();
            Procedures = new HashSet<Procedure>();
        }

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
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string EmailId { get; set; }
        //public PatientsNominee patientsNominee { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Diagnosis> Diagnoses { get; set; }
        public virtual ICollection<PatientVisit> PatientVisits { get; set; }
        public virtual ICollection<Procedure> Procedures { get; set; }
    }
}
