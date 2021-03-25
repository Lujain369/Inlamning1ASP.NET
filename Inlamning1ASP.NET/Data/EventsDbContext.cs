using Inlamning1ASP.NET.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Inlamning1ASP.NET.Data
{
    public class EventsDbContext : DbContext
    {
        public EventsDbContext(DbContextOptions<EventsDbContext> options)
         : base(options)

        {
        }

        public DbSet<Event> Event { get; set; }
        public DbSet<Attender> Attender { get; set; }
        public DbSet<Organisation> Organisation { get; set; }
        public DbSet<AttenderEvent> AttenderEvents { get; set; }

        
    }
}
