using System;

namespace AskUsFresh.Domain
{
    public class User
    {
        public string EmailAddress { get; set; }

        public string UserName {get;set;}

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public Address Address { get; set; }
    }
}
