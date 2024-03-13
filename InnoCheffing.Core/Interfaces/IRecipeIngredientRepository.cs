using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.Core.Interfaces;

public interface IRecipeIngredientRepository
{
    Task Create(RecipeIngredient recipeIngredient);
    Task<RecipeIngredient> Read(Guid recipeId, Guid ingredientId);
    Task<IEnumerable<RecipeIngredient>> Read(Guid recipeId);
}
