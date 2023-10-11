using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RokFakz.Models;

namespace RokFakz.Data
{
    public class RokFakzContext : DbContext
    {
        public RokFakzContext (DbContextOptions<RokFakzContext> options)
            : base(options)
        {
        }

        public DbSet<RokFakz.Models.RokFak> RokFak { get; set; } = default!;
    }
}
