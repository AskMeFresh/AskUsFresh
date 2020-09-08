using System;
using System.Collections.Generic;
using System.Text;
using AskUsFresh.Domain.DTO;

namespace AskUsFresh.Service.Interfaces
{
   public interface IAddressApplicationService
    {
        public void AddUserAddresses(IEnumerable<AddressForCreationDTO> userAddressesDTO, int userId);
    }
}
