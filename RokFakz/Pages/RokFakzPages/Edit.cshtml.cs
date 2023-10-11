using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RokFakz.Data;
using RokFakz.Models;

namespace RokFakz.Pages.RokFakzPages
{
    public class EditModel : PageModel
    {
        private readonly RokFakz.Data.RokFakzContext _context;

        public EditModel(RokFakz.Data.RokFakzContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RokFak RokFak { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.RokFak == null)
            {
                return NotFound();
            }

            var rokfak =  await _context.RokFak.FirstOrDefaultAsync(m => m.Id == id);
            if (rokfak == null)
            {
                return NotFound();
            }
            RokFak = rokfak;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(RokFak).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RokFakExists(RokFak.Id))
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

        private bool RokFakExists(int id)
        {
          return (_context.RokFak?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
