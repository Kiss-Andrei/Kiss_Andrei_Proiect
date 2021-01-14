using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kiss_Andrei_Proiect.Data;
using Kiss_Andrei_Proiect.Models;

namespace Kiss_Andrei_Proiect.Pages.Bita
{
    public class CreateModel : PageModel
    {
        private readonly Kiss_Andrei_Proiect.Data.Kiss_Andrei_ProiectContext _context;

        public CreateModel(Kiss_Andrei_Proiect.Data.Kiss_Andrei_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Bikes Bikes { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bikes.Add(Bikes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
