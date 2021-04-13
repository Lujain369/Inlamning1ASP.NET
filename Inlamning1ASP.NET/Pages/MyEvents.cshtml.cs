using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inlamning1ASP.NET.Data;
using Inlamning1ASP.NET.models;

namespace Inlamning1ASP.NET.Pages
{
    public class MyEventsModel : PageModel
    {
        private readonly EventsDbContext _context;

        public MyEventsModel(EventsDbContext context)
        {
            _context = context;
        }

        public IList<AttenderEvent> AttenderEvents { get;set; }

        public async Task OnGetAsync()
        {
            AttenderEvents = await _context.AttenderEvents
                .Include(a => a.Attender)
                .Include(a => a.Event).ToListAsync();
        }
    }
}
