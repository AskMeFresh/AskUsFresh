using AskUsFresh.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AskUsFresh.Service.Interfaces
{
   public interface IRegisterService
    {
        public void RegisterUser(Users user);

        public Users GetUserByEmailandMobileNumber(string email, int mobileNumber);

        public Users GetUserByEmail(string email);

        public Users GetUserByMobileNumber(int mobileNumber);

        public int Commit();
    }
}
