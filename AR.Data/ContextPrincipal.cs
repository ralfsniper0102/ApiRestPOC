using AP.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace AR.Data
{
    public class ContextPrincipal : DbContext
    {
        public ContextPrincipal(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Client> Client { get; set; }
    }
}
