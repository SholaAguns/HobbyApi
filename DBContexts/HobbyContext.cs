using HobbyApi.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HobbyApi.DBContexts
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions<HobbyContext> options)
            : base(options)
        {
        }

        public DbSet<Hobby> Hobbies { get; set; }
    }
}
