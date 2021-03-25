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

        public static void StartSeed(EventsDbContext context)
        {
            //context.Attender.RemoveRange(context.Attender);
            //context.Event.RemoveRange(context.Event);

            Attender Lolo = new Attender { name = "Lolo", email = "antonberglund@hotmail.com", phone_number = "0731337123" };
            context.Attender.Add(Lolo);

            context.Event.AddRange(new List<Event>()
            {
                 new Event(){ title="Bollspel", date=DateTime.Now, adress="Norrköping", spots_available=400},
                 new Event(){ title="Coronafest", date=DateTime.Now, adress="Kungsbacka", spots_available=400},
                 new Event(){ title="Fotboll", date=DateTime.Now, adress="Göteborg", spots_available=400},
                 new Event(){ title="Vintest", date=DateTime.Now, adress="Mölndal", spots_available=400},

            });

            context.SaveChanges();
        }
    }
}
