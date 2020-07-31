using AskUsFresh.Domain;
using AskUsFresh.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection.Metadata;

namespace AskUsFresh.Service
{
    public class RegisterService : IRegisterService
    {
        private AskUsFreshDBContext db { get; set; }
        public RegisterService()
        {
            this.db = new AskUsFreshDBContext();
        }
        public void RegisterUser(User user) 
        {
            var userExists = this.GetUserByEmailandMobileNumber(user.EmailAddress, user.PhoneNumber);
            if(userExists != null)
            {
                this.db.Add(user);
            }
        }

        public User GetUserByEmailandMobileNumber(string email, string mobileNumber)
        {

            return this.db.User.Where(u => u.EmailAddress == email || 
            u.PhoneNumber == mobileNumber).SingleOrDefault();
        }

        public int Commit()
        {
            return this.db.SaveChanges();
        }
    }
}
