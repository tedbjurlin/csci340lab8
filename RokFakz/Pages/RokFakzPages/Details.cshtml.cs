using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RokFakz.Data;
using RokFakz.Models;

namespace RokFakz.Pages.RokFakzPages
{
    public class DetailsModel : PageModel
    {
        private readonly RokFakz.Data.RokFakzContext _context;

        public DetailsModel(RokFakz.Data.RokFakzContext context)
        {
            _context = context;
        }

      public RokFak RokFak { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.RokFak == null)
            {
                return NotFound();
            }

            var rokfak = await _context.RokFak.FirstOrDefaultAsync(m => m.Id == id);
            if (rokfak == null)
            {
                return NotFound();
            }
            else 
            {
                RokFak = rokfak;
            }
            return Page();
        }
    }
}
