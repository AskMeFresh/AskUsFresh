using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AskUsFresh.Domain;
using AskUsFresh.Domain.DTO;
using AskUsFresh.Service;
using AskUsFresh.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;


namespace AskUsFresh.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        private IUserApplicationService _registerService { get; set; }
        public RegisterController(IUserApplicationService registerService) 
        {
            this._registerService = registerService;
        }

        [HttpPost]
        public void Post(UserForCreationDTO user) 
        {

            this._registerService.RegisterUser(user);
        
        }

        public void Get(string userId)
        { 
        
        }
    }
}
