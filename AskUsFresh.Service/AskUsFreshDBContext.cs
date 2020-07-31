using AskUsFresh.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AskUsFresh.Service
{
   public class AskUsFreshDBContext : DbContext
    {
        public DbSet<User> User { get; set; }
    }
}
