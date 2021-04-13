using Inlamning1ASP.NET.Data;
using Inlamning1ASP.NET.models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlamning1ASP.NET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            StartSeed(host);
            host.Run();
        }

        public static void StartSeed(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<EventsDbContext>();

                context.Attender.RemoveRange(context.Attender);
                context.Event.RemoveRange(context.Event);


                context.Attender.AddRange(new List<Attender>()
                {
                   new Attender() { name = "Lolo", email = "Lolo@hotmail.com", phone_number = "0731337123" },

                });


                context.Organisation.AddRange(new List<Organisation>()
                {
                    new Organisation(){name = "hej", email="hej@gmail.com", phone_number="0738723564"},

                });
                context.Event.AddRange(new List<Event>()
                {
                 new Event(){ title="Bollspel", description="Lagspel och olika bollspel", date=DateTime.Now, place="Norrköping", spots_available=400},
                 new Event(){ title="Coronafest",description="Festa för att corona är slut", date=DateTime.Now, place="Kungsbacka", spots_available=400},
                 new Event(){ title="Fotboll",description="Träning i grupp", date=DateTime.Now, place="Göteborg", spots_available=400},
                 new Event(){ title="Vintest",description="Testa på dyra och billiga vin", date=DateTime.Now, place="Mölndal", spots_available=400},

                });

                context.SaveChanges();

            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
