using AskUsFresh.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AskUsFresh.Service.Interfaces
{
   public interface IRegisterService
    {
        public void RegisterUser(User user);
    }
}
