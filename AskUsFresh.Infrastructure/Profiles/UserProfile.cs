using AskUsFresh.Domain.DTO;
using AskUsFresh.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AskUsFresh.Infrastructure.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserForCreationDTO, User>();
            CreateMap<User, UserForCreationDTO>();
        }
    }
}
