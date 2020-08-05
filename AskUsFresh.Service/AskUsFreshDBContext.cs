using AskUsFresh.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AskUsFresh.Service
{
    public class AskUsFreshDBContext : DbContext
    {
        public AskUsFreshDBContext(DbContextOptions<AskUsFreshDBContext> options)
            :base(options)
        { 
        
        }
        public DbSet<User> User { get; set; }
    }
}
