using AskUsFresh.Domain.DTO;
using AskUsFresh.Domain.Entities;
using AskUsFresh.Domain.Interface;
using AskUsFresh.Infrastructure;
using AskUsFresh.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AskUsFresh.Service.ApplicationService
{
    public class UserApplicationService : IUserApplicationService
    {
        private IUserService _userService { get; set; }

        private IAddressApplicationService _addressApplicationService { get; set; }
        public UserApplicationService(IUserService userService, IAddressApplicationService addressApplicationService)
        {
            this._userService = userService;
            this._addressApplicationService = addressApplicationService;
        }
        public UserForCreationDTO GetUserByEmail(string email)
        {
            var user = this._userService.GetUserByEmail(email);
            var userDTO = Mapping.Mapper.Map<UserForCreationDTO>(user);
            return userDTO;
        }

        public UserForCreationDTO GetUserByEmailandMobileNumber(string email, string mobileNumber)
        {
            var user = this._userService.GetUserByEmailandMobileNumber(email, mobileNumber);
            var userDTO = Mapping.Mapper.Map<UserForCreationDTO>(user);
            return userDTO;
        }

        public UserForCreationDTO GetUserByMobileNumber(string mobileNumber)
        {
            var user = this._userService.GetUserByMobileNumber(mobileNumber);
            var userDTO = Mapping.Mapper.Map<UserForCreationDTO>(user);
            return userDTO;
        }

        public int RegisterUser(UserForCreationDTO userForCreation)
        {
            var user = Mapping.Mapper.Map<User>(userForCreation);
            var doctorAddresses = Mapping.Mapper.Map<IEnumerable<AddressForCreationDTO>>(userForCreation.addresses);
            
            int userId = this._userService.RegisterUser(user);
            if (userId > 0)
            {
                this._addressApplicationService.AddUserAddresses(userForCreation.addresses, userId);
  
            }
            return 1;

        }
    }
}
