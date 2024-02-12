using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCheffing.Core.Entities.DataBase;

[Table(nameof(RecipeIngredient))]
public class RecipeIngredient : Entity
{
    public Guid IngredientId { get; set; }
    public Ingredient Ingredient { get; set; }
    public Guid RecipeId { get; set; }
    public Recipe Recipe { get; set; }

    [Required]
    [MaxLength(150)]
    public string IngredientQuantity { get; set; }

}
