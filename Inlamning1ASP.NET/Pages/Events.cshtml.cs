using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inlamning1ASP.NET.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Inlamning1ASP.NET.Pages
{
    public class EventsModel : PageModel
    {
        private readonly Data.EventsDbContext eventsDbContext; 

        public EventsModel(Data.EventsDbContext context)
        {
            eventsDbContext = context;
        }

        public IList<Event> Event { get; set; }

        public async Task OnGetAsync()
        {
            Event = await eventsDbContext.Event.ToListAsync();
        }
    }
}
