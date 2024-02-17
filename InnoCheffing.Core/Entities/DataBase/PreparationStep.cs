using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCheffing.Core.Entities.DataBase;

[Table(nameof(PreparationStep))]
public class PreparationStep : Entity
{
    public int? StepNumber { get; set; }
    [MaxLength(500)]
    public string? Step { get; set; }
    [Required]
    [ForeignKey(nameof(Recipe))]
    public Guid RecipeId { get; set; }
    public Recipe Recipe { get; set; }
}
