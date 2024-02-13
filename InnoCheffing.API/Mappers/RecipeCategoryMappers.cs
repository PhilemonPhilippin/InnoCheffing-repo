using InnoCheffing.API.Contracts;
using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.API.Mappers;

internal static class RecipeCategoryMappers
{
    internal static RecipeCategoryDto MapToCategoryDto(this RecipeCategory category) => new(category.Id, category.Name);
}
