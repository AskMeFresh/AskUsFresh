using System;
using System.ComponentModel.DataAnnotations;

namespace AskUsFresh.Domain
{
    public class Users
    {
        [Key]
        public int Id { get; set; }  
        public string FirstName { get; set; }

        public string LastName { get;set;}

        public string Email { get; set; }

        public string Password { get; set; }

        public int PhoneNumber { get; set; }

      //  public Address Address { get; set; }
    }
}
