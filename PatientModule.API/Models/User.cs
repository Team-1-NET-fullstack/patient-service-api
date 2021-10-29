using System;
using System.Collections.Generic;

#nullable disable

namespace PatientModule.API.Models
{
    public partial class User
    {
        public User()
        {
            AllergyCreatedByNavigations = new HashSet<Allergy>();
            AllergyMasterCreatedByNavigations = new HashSet<AllergyMaster>();
            AllergyMasterUpdatedByNavigations = new HashSet<AllergyMaster>();
            AllergyUpdatedByNavigations = new HashSet<Allergy>();
            AppointmentCreatedByNavigations = new HashSet<Appointment>();
            AppointmentPhysicians = new HashSet<Appointment>();
            AppointmentUpdatedByNavigations = new HashSet<Appointment>();
            Diagnoses = new HashSet<Diagnosis>();
            MedicationsMasterCreatedByNavigations = new HashSet<MedicationsMaster>();
            MedicationsMasterUpdatedByNavigations = new HashSet<MedicationsMaster>();
            NoteCreatedByNavigations = new HashSet<Note>();
            NoteReceiverNavigations = new HashSet<Note>();
            NoteSenderNavigations = new HashSet<Note>();
            NoteUpdatedByNavigations = new HashSet<Note>();
            PatientVisitCreatedByNavigations = new HashSet<PatientVisit>();
            PatientVisitPhysicians = new HashSet<PatientVisit>();
            PatientVisitUpdatedByNavigations = new HashSet<PatientVisit>();
            ProcedureMasterCreatedByNavigations = new HashSet<ProcedureMaster>();
            ProcedureMasterUpdatedByNavigations = new HashSet<ProcedureMaster>();
            Procedures = new HashSet<Procedure>();
        }

        public int UserId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public DateTime Dob { get; set; }
        public int? EmployeeId { get; set; }
        public byte[] Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int RoleId { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Allergy> AllergyCreatedByNavigations { get; set; }
        public virtual ICollection<AllergyMaster> AllergyMasterCreatedByNavigations { get; set; }
        public virtual ICollection<AllergyMaster> AllergyMasterUpdatedByNavigations { get; set; }
        public virtual ICollection<Allergy> AllergyUpdatedByNavigations { get; set; }
        public virtual ICollection<Appointment> AppointmentCreatedByNavigations { get; set; }
        public virtual ICollection<Appointment> AppointmentPhysicians { get; set; }
        public virtual ICollection<Appointment> AppointmentUpdatedByNavigations { get; set; }
        public virtual ICollection<Diagnosis> Diagnoses { get; set; }
        public virtual ICollection<MedicationsMaster> MedicationsMasterCreatedByNavigations { get; set; }
        public virtual ICollection<MedicationsMaster> MedicationsMasterUpdatedByNavigations { get; set; }
        public virtual ICollection<Note> NoteCreatedByNavigations { get; set; }
        public virtual ICollection<Note> NoteReceiverNavigations { get; set; }
        public virtual ICollection<Note> NoteSenderNavigations { get; set; }
        public virtual ICollection<Note> NoteUpdatedByNavigations { get; set; }
        public virtual ICollection<PatientVisit> PatientVisitCreatedByNavigations { get; set; }
        public virtual ICollection<PatientVisit> PatientVisitPhysicians { get; set; }
        public virtual ICollection<PatientVisit> PatientVisitUpdatedByNavigations { get; set; }
        public virtual ICollection<ProcedureMaster> ProcedureMasterCreatedByNavigations { get; set; }
        public virtual ICollection<ProcedureMaster> ProcedureMasterUpdatedByNavigations { get; set; }
        public virtual ICollection<Procedure> Procedures { get; set; }
    }
}
