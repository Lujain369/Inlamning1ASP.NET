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
    public class IndexModel : PageModel
    {
        private readonly EventsDbContext _context;

        public IndexModel(EventsDbContext context)
        {
            _context = context;
        }
        public Attender Attender { get; set; }

        public List<Attender> Attenders { get; set; }
        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Attenders = await _context.Attender
                .Where(m => m.Id == 1)
                .ToListAsync();
           
                
            Event = await _context.Event.ToListAsync();
        }
    }
}
