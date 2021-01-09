using System;
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
    public class DeleteModel : PageModel
    {
        private readonly Gorgan_Sorana_Proiect.Data.Gorgan_Sorana_ProiectContext _context;

        public DeleteModel(Gorgan_Sorana_Proiect.Data.Gorgan_Sorana_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Parfum Parfum { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Parfum = await _context.Parfum.FirstOrDefaultAsync(m => m.ID == id);

            if (Parfum == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Parfum = await _context.Parfum.FindAsync(id);

            if (Parfum != null)
            {
                _context.Parfum.Remove(Parfum);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
