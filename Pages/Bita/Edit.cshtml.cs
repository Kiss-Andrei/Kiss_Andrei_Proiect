using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kiss_Andrei_Proiect.Data;
using Kiss_Andrei_Proiect.Models;

namespace Kiss_Andrei_Proiect.Pages.Bita
{
    public class EditModel : PageModel
    {
        private readonly Kiss_Andrei_Proiect.Data.Kiss_Andrei_ProiectContext _context;

        public EditModel(Kiss_Andrei_Proiect.Data.Kiss_Andrei_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Bikes Bikes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bikes = await _context.Bikes.FirstOrDefaultAsync(m => m.ID == id);

            if (Bikes == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Bikes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BikesExists(Bikes.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BikesExists(int id)
        {
            return _context.Bikes.Any(e => e.ID == id);
        }
    }
}
