using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCheffing.Core.Entities;

[Table(nameof(Recipe))]
public class Recipe : Entity
{
    [MaxLength(500)]
    public string? Description { get; set; }

    [ForeignKey(nameof(RecipeCategoryId))]
    public RecipeCategory RecipeCategory { get; set; }
    public Guid RecipeCategoryId { get; set; }

    public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
}
