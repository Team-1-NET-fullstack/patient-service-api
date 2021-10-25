using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient.Api.Profiles
{
    public class PatientProfile: Profile
    {
        public PatientProfile()
        {
            CreateMap<Patient.Api.Models.Patient, Patient.Api.Models.DTOs.PatientDto>().ReverseMap();


        }
    }
}
