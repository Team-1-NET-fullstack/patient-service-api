﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PatientModule.API.Models
{
    public partial class PatientsNominee
    {
        public int NomineeId { get; set; }
        public int PatientId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string EmailId { get; set; }
        public string Relationship { get; set; }
        public string ContactNumber { get; set; }
        public string NomineeAddress { get; set; }
        public DateTime InsertDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
