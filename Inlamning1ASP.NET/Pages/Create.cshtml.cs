using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Inlamning1ASP.NET.Data;
using Inlamning1ASP.NET.models;

namespace Inlamning1ASP.NET.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Inlamning1ASP.NET.Data.EventsDbContext _context;

        public CreateModel(Inlamning1ASP.NET.Data.EventsDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Event Event { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Event.Add(Event);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
