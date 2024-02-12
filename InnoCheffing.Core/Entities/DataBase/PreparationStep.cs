using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCheffing.Core.Entities.DataBase;

[Table(nameof(PreparationStep))]
public class PreparationStep : Entity
{
    [Required]
    public int StepNumber { get; set; }

    [Required]
    [MaxLength(500)]
    public string Step { get; set; }

    [ForeignKey(nameof(RecipeId))]
    public Recipe Recipe { get; set; }
    public Guid RecipeId { get; set; }
}
