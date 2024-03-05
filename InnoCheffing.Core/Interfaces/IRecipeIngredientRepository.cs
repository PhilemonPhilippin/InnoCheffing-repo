using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.Core.Interfaces;

public interface IRecipeIngredientRepository
{
    Task Create(RecipeIngredient recipeIngredient);
}
