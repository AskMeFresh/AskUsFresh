using System;
using System.Collections.Generic;
using System.Text;
using AskUsFresh.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace AskUsFresh.Domain
{

    public class AskUsFreshDBContext : DbContext
    {
        public AskUsFreshDBContext(DbContextOptions<AskUsFreshDBContext> options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }
}
