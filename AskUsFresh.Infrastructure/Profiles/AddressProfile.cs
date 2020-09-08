using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using AskUsFresh.Domain.DTO;
using AskUsFresh.Domain.Entities;

namespace AskUsFresh.Infrastructure.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressForCreationDTO, Address>();
            CreateMap<Address, AddressForCreationDTO>();
        }
    }
}
