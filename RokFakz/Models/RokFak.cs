using System.ComponentModel.DataAnnotations;

namespace RokFakz.Models;

public class RokFak
{
    public int Id { get; set; }
    public string? Rock { get; set; }

    public decimal MohsHardness { get; set; }

    public decimal Density { get; set; }
    public string? Texture { get; set; }
    public string? Color { get; set; }
    public string? Fak { get; set; }
}