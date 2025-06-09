using System.ComponentModel.DataAnnotations;

namespace Shared;

public class TopUpRequestCreateDto
{
  [Required]
  [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
  public decimal Amount { get; set; }
  [MaxLength(50)]
  public string Type { get; set; } = "Efectivo";
  [MaxLength(255)]
  public string? Receipt { get; set; }
  [Required]
  public string TargetUserId { get; set; } = null!;
  public string RequestedByUserId { get; set; } = null!;
}