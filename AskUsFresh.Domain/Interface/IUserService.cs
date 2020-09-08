using AskUsFresh.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AskUsFresh.Domain.Interface
{
    public interface IUserService
    {
        public int RegisterUser(User user);

        public User GetUserByEmailandMobileNumber(string email, string mobileNumber);

        public User GetUserByEmail(string email);

        public User GetUserByMobileNumber(string mobileNumber);
    }
}
