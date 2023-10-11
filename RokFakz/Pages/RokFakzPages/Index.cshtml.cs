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
    public class IndexModel : PageModel
    {
        private readonly RokFakz.Data.RokFakzContext _context;

        public IndexModel(RokFakz.Data.RokFakzContext context)
        {
            _context = context;
        }

        public IList<RokFak> RokFak { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.RokFak != null)
            {
                RokFak = await _context.RokFak.ToListAsync();
            }
        }
    }
}
