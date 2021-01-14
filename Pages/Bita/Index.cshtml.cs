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
    public class IndexModel : PageModel
    {
        private readonly Kiss_Andrei_Proiect.Data.Kiss_Andrei_ProiectContext _context;

        public IndexModel(Kiss_Andrei_Proiect.Data.Kiss_Andrei_ProiectContext context)
        {
            _context = context;
        }

        public IList<Bikes> Bikes { get;set; }

        public async Task OnGetAsync()
        {
            Bikes = await _context.Bikes.ToListAsync();
        }
    }
}
