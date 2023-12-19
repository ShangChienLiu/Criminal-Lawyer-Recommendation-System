using AutoMapper;
using LawyerUpBackend.Application.Models.Case;
using LawyerUpBackend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerUpBackend.Application.Profiles
{
    public class CaseProfile:Profile
    {
        public CaseProfile()
        {
            CreateMap<Case, CaseResponseModel>();
             
            //CreateMap<Lawyer, LawyerListResponseModel>().ForMember(target => target.Id, option => option.MapFrom(source => source.Id));
        }
       
    }
}
