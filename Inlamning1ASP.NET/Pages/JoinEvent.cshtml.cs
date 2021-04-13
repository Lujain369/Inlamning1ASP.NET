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
    public class JoinEventModel : PageModel
    {
        private readonly EventsDbContext _context;

        public JoinEventModel(EventsDbContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }
        public Attender Attender { get; set; }
       
       

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event
                .Include(e => e.Organisation)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            
                AttenderEvent joining = new AttenderEvent()
                {
                    Attender = await _context.Attender.Where(a => a.Id == 1).FirstOrDefaultAsync(),
                    Event = await _context.Event.Where(e => e.Id == id).FirstOrDefaultAsync(),

                };

            _context.AttenderEvents.Add(joining);

            _context.Event.Where(e => e.Id == id).First().spots_available--;

            await _context.SaveChangesAsync();
            
            return RedirectToPage("/EfterJoining", new { id });
        }
    }
}
