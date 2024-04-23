using AuthSystem.Application.DTOs.Auth;
using AuthSystem.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthSystem.Application.Profiles
{
    public class MappingProfiles : Profile
    {

        public MappingProfiles()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
