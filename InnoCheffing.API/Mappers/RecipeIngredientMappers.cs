using InnoCheffing.API.Contracts;
using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.API.Mappers;

internal static class RecipeIngredientMappers
{
    internal static RecipeIngredient MapToRecipeIngredient(this RecipeIngredientPostRequest request)
    {
        return new()
        {
            IngredientId = request.IngredientId,
            RecipeId = request.RecipeId,
            IngredientQuantity = request.IngredientQuantity
        };
    }

    internal static RecipeIngredientDto MapToDto(this RecipeIngredient recipeIngredient) => 
        new(recipeIngredient.IngredientId, recipeIngredient.RecipeId, recipeIngredient.IngredientQuantity);
}
