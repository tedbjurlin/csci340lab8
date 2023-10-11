using Microsoft.EntityFrameworkCore;
using RokFakz.Data;

namespace RokFakz.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RokFakzContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RokFakzContext>>()))
        {
            if (context == null || context.RokFak == null)
            {
                throw new ArgumentNullException("Null RazorPagesRokFakContext");
            }

            // Look for any RokFaks.
            if (context.RokFak.Any())
            {
                return;   // DB has been seeded
            }

            context.RokFak.AddRange(
                new RokFak
                {
                    Rock = "Granite",
                    MohsHardness = 6,
                    Density = 2.7M,
                    Texture = "Rough",
                    Color = "Pink",
                    Fak = "Granite belongs to the group of rocks known as the \"monotremes\"."
                },

                new RokFak
                {
                    Rock = "Quartz",
                    MohsHardness = 7,
                    Density = 2.65M,
                    Texture = "Bumpy",
                    Color = "Clear",
                    Fak = "Quartz is bioflourescent."
                },

                new RokFak
                {
                    Rock = "Topaz",
                    MohsHardness = 8,
                    Density = 3.55M,
                    Texture = "Smooth",
                    Color = "Yellow",
                    Fak = "Topaz can have venomous spurs."
                },

                new RokFak
                {
                    Rock = "Limestone",
                    MohsHardness = 4,
                    Density = 2.75M,
                    Texture = "Chalky",
                    Color = "Khaki",
                    Fak = "Limestone produces milk, but doesn't have nipples."
                },

                new RokFak
                {
                    Rock = "Sandstone",
                    MohsHardness = 6,
                    Density = 2.32M,
                    Texture = "Grainy",
                    Color = "Khaki",
                    Fak = "Sandstone is semi-aquatic."
                }
            );
            context.SaveChanges();
        }
    }
}