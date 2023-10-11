using System.ComponentModel.DataAnnotations;

namespace RokFakz.Models;

public class RokFak
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 1)]
    [Required]
    public string? Rock { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Mohs Hardness")]
    [Range(1, 10)]
    public decimal MohsHardness { get; set; }

    [Required]
    [Display(Name = "Density (g/cm³)")]
    public decimal Density { get; set; }

    [Required]
    [StringLength(30)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    public string? Texture { get; set; }
    [Required]
    [StringLength(30)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    public string? Color { get; set; }
    [Required]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    public string? Fak { get; set; }
}