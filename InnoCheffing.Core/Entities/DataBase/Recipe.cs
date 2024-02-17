using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCheffing.Core.Entities.DataBase;

[Table(nameof(Recipe))]
public class Recipe : Entity
{
    [MaxLength(500)]
    public string? Description { get; set; }

    [ForeignKey(nameof(RecipeCategory))]
    public Guid? RecipeCategoryId { get; set; }
    public RecipeCategory? RecipeCategory { get; set; }

    public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
}
