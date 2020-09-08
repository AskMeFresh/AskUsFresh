using AskUsFresh.Domain.Entities;
using AskUsFresh.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AskUsFresh.Domain.Service
{
    public class AddressService : IAddressService
    {

        private AskUsFreshDBContext _db { get; set; }

        public AddressService(AskUsFreshDBContext db) 
        {
            this._db = db;
        }

        public void AddUserAddresses(IEnumerable<Address> userAddresses)
        {
            var usrAddresses = userAddresses.ToList();
            for (int i = 0; i < userAddresses.Count(); i++)
            {
                this._db.Add(usrAddresses[i]);
                this.Commit();
            }
            throw new NotImplementedException();
        }

        public int Commit()
        {
            return this._db.SaveChanges();
        }
    }
}
