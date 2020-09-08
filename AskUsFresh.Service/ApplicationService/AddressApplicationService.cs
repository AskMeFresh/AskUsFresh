using AskUsFresh.Domain.DTO;
using AskUsFresh.Domain.Interface;
using AskUsFresh.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using AskUsFresh.Infrastructure;
using AskUsFresh.Domain.Entities;
using System.Linq;

namespace AskUsFresh.Service.ApplicationService
{
    public class AddressApplicationService : IAddressApplicationService
    {
        private IAddressService _addressService { get; set; }

        public AddressApplicationService(IAddressService addressService)
        {
            this._addressService = addressService;
        }

        public void AddUserAddresses(IEnumerable<AddressForCreationDTO> userAddressesDTO, int userId)
        {
            var userAddresses = Mapping.Mapper.Map<IEnumerable<Address>>(userAddressesDTO);
            userAddresses = userAddresses.Select(usraddrs => { usraddrs.UserId = userId; return usraddrs; }).ToList();
            this._addressService.AddUserAddresses(userAddresses);
        }
    }
}
