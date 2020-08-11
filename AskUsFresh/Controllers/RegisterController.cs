using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AskUsFresh.Domain;
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
        private IRegisterService _registerService { get; set; }
        public RegisterController(IRegisterService registerService) 
        {
            this._registerService = registerService;
        }

        [HttpPost]
        public void Post(Users user) 
        {

            this._registerService.RegisterUser(user);
        
        }

        public void Get(string userId)
        { 
        
        }
    }
}
