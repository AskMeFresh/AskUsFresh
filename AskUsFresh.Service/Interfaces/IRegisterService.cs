using AskUsFresh.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AskUsFresh.Service.Interfaces
{
   public interface IRegisterService
    {
        public void RegisterUser(User user);

        public User GetUserByEmailandMobileNumber(string email,string mobileNumber);

        public int Commit();
    }
}
