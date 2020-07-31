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
        private IRegisterService registerService { get; set; }
        public RegisterController() 
        {
            this.registerService = new RegisterService();
        }

        [HttpPost]
        public void Post(User user) 
        {

            this.registerService.RegisterUser(user);
        
        }
    }
}
