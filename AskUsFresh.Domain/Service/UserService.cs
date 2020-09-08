using AskUsFresh.Domain.Entities;
using AskUsFresh.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AskUsFresh.Domain.Service
{
    public class UserService : IUserService
    {
        public AskUsFreshDBContext _db { get; set; }
        public UserService(AskUsFreshDBContext db)
        {
            this._db = db;
        }

        public int commit()
        {
           return this._db.SaveChanges();
        }

        public int RegisterUser(User user)
        {
            this._db.Add(user);
            return this.commit();
        }

        public User GetUserByEmailandMobileNumber(string email, string mobileNumber)
        {
            return this._db.Users.Where(u => u.Email == email ||
            u.PhoneNumber == mobileNumber).SingleOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return this._db.Users.Where(u => u.Email == email).SingleOrDefault();
        }

        public User GetUserByMobileNumber(string mobileNumber)
        {
            return this._db.Users.Where(u => u.PhoneNumber == mobileNumber).SingleOrDefault();
        }
    }
}
