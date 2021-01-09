﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gorgan_Sorana_Proiect.Data;
using Gorgan_Sorana_Proiect.Models;

namespace Gorgan_Sorana_Proiect.Pages.Parfumuri
{
    public class IndexModel : PageModel
    {
        private readonly Gorgan_Sorana_Proiect.Data.Gorgan_Sorana_ProiectContext _context;

        public IndexModel(Gorgan_Sorana_Proiect.Data.Gorgan_Sorana_ProiectContext context)
        {
            _context = context;
        }

        public IList<Parfum> Parfum { get;set; }

        public ParfumData ParfumD { get; set; }
        public int ParfumID { get; set; }
        public int AromaID { get; set; }
        public async Task OnGetAsync(int? id, int? aromaID)
        {
            ParfumD = new ParfumData();

            ParfumD.Parfumuri = await _context.Parfum
            .Include(b => b.Brand)
            .Include(b => b.Gen)
            .Include(b => b.AromeParfum)
            .ThenInclude(b => b.Aroma)
            .AsNoTracking()
            .OrderBy(b => b.Denumire)
            .ToListAsync();
            if (id != null)
            {
                ParfumID = id.Value;
                Parfum parfum = ParfumD.Parfumuri
                .Where(i => i.ID == id.Value).Single();
                ParfumD.Arome = parfum.AromeParfum.Select(s => s.Aroma);
            }
        }
    }
}
