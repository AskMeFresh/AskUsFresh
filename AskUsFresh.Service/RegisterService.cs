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
        public RegisterService(AskUsFreshDBContext db)
        {
            this.db = db;
        }
        public void RegisterUser(Users user) 
        {
            var userExists = this.GetUserByEmailandMobileNumber(user.Email, user.PhoneNumber);
            if(userExists != null)
            {
                this.db.Add(user);
            }
        }

        public Users GetUserByEmailandMobileNumber(string email, int mobileNumber)
        {

            return this.db.Users.Where(u => u.Email == email || 
            u.PhoneNumber == mobileNumber).SingleOrDefault();
        }

        public Users GetUserByEmail(string email)
        {
            return this.db.Users.Where(u => u.Email == email).SingleOrDefault();
        }


        public Users GetUserByMobileNumber(int mobileNumber)
        {
            return this.db.Users.Where(u => u.PhoneNumber == mobileNumber).SingleOrDefault();
        }

        public int Commit()
        {
            return this.db.SaveChanges();
        }
    }
}
