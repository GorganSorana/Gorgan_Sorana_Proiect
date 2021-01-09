using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gorgan_Sorana_Proiect.Models;

namespace Gorgan_Sorana_Proiect.Data
{
    public class Gorgan_Sorana_ProiectContext : DbContext
    {
        public Gorgan_Sorana_ProiectContext (DbContextOptions<Gorgan_Sorana_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Gorgan_Sorana_Proiect.Models.Parfum> Parfum { get; set; }

        public DbSet<Gorgan_Sorana_Proiect.Models.Brand> Brand { get; set; }

        public DbSet<Gorgan_Sorana_Proiect.Models.Aroma> Aroma { get; set; }

        public DbSet<Gorgan_Sorana_Proiect.Models.Gen> Gen { get; set; }

    
    }
}
