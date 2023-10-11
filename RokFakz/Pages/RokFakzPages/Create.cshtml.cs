using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RokFakz.Data;
using RokFakz.Models;

namespace RokFakz.Pages.RokFakzPages
{
    public class CreateModel : PageModel
    {
        private readonly RokFakz.Data.RokFakzContext _context;

        public CreateModel(RokFakz.Data.RokFakzContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RokFak RokFak { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.RokFak == null || RokFak == null)
            {
                return Page();
            }

            _context.RokFak.Add(RokFak);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
