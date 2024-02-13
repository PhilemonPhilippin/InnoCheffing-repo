using InnoCheffing.API.Contracts;
using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.API.Mappers;

internal static class IngredientMappers
{
    internal static IngredientDto MapToIngredientDto(this Ingredient ingredient) => new(ingredient.Id, ingredient.Name);
}