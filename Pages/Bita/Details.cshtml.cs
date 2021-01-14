using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kiss_Andrei_Proiect.Data;
using Kiss_Andrei_Proiect.Models;

namespace Kiss_Andrei_Proiect.Pages.Bita
{
    public class DetailsModel : PageModel
    {
        private readonly Kiss_Andrei_Proiect.Data.Kiss_Andrei_ProiectContext _context;

        public DetailsModel(Kiss_Andrei_Proiect.Data.Kiss_Andrei_ProiectContext context)
        {
            _context = context;
        }

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
    }
}
