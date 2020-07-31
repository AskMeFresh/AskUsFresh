using AskUsFresh.Domain;
using AskUsFresh.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
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
            this.db.Add(user);
        }
    }
}
