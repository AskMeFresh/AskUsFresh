using AskUsFresh.Domain;
using AskUsFresh.Domain.DTO;
using AskUsFresh.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AskUsFresh.Service.Interfaces
{
   public interface IUserApplicationService
    {
        public int RegisterUser(UserForCreationDTO userForCreation);

        public UserForCreationDTO GetUserByEmailandMobileNumber(string email, string mobileNumber);

        public UserForCreationDTO GetUserByEmail(string email);

        public UserForCreationDTO GetUserByMobileNumber(string mobileNumber);

    }
}
