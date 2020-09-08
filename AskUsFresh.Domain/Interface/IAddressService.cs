using System;
using System.Collections.Generic;
using System.Text;
using AskUsFresh.Domain.Entities;

namespace AskUsFresh.Domain.Interface
{
    public interface IAddressService
    {
        public void AddUserAddresses(IEnumerable<Address> userAddresses);
    }
}
