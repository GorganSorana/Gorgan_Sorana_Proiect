﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gorgan_Sorana_Proiect.Data;
using Gorgan_Sorana_Proiect.Models;

namespace Gorgan_Sorana_Proiect.Pages.Genuri
{
    public class IndexModel : PageModel
    {
        private readonly Gorgan_Sorana_Proiect.Data.Gorgan_Sorana_ProiectContext _context;

        public IndexModel(Gorgan_Sorana_Proiect.Data.Gorgan_Sorana_ProiectContext context)
        {
            _context = context;
        }

        public IList<Gen> Gen { get;set; }

        public async Task OnGetAsync()
        {
            Gen = await _context.Gen.ToListAsync();
        }
    }
}
