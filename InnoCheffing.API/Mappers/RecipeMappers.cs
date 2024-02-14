using InnoCheffing.API.Contracts;
using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.API.Mappers;

internal static class RecipeMappers
{
    internal static RecipeDto MapToRecipeDto(this Recipe recipe) => new(recipe.Id, recipe.Name, recipe.Description, recipe.RecipeCategoryId);
}
