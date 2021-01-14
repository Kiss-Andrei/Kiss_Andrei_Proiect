using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kiss_Andrei_Proiect.Models;

namespace Kiss_Andrei_Proiect.Data
{
    public class Kiss_Andrei_ProiectContext : DbContext
    {
        public Kiss_Andrei_ProiectContext (DbContextOptions<Kiss_Andrei_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Kiss_Andrei_Proiect.Models.Bikes> Bikes { get; set; }
    }
}
