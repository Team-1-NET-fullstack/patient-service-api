using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Patient.Api.Profiles
{
    public class PatientVisitProfile:Profile
    {
        public PatientVisitProfile()
        {
            CreateMap<Models.PatientVisit, Models.DTOs.PatientVisitDto>().ReverseMap(); 
        }

      
    }
}
