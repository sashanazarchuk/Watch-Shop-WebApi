using BusinessLogic.DTOs;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Profiles
{
    public class ApplicationProfile: AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Watch, WatchDto>()
                .ForMember(d => d.ClockFaceId, opt => opt.MapFrom(s => s.ClockFaceId))
                .ForMember(d => d.ClockFace, opt => opt.MapFrom(s => s.ClockFace.Name));

            CreateMap<WatchDto, Watch>()
                .ForMember(d => d.ClockFaceId, opt => opt.MapFrom(s => s.ClockFaceId));
        }
    }
}
