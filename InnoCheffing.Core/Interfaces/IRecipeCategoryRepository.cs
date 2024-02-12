using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.Core.Interfaces;

public interface IRecipeCategoryRepository
{
    Task<IEnumerable<RecipeCategory>> Read();
    Task Create(RecipeCategory category);
}
