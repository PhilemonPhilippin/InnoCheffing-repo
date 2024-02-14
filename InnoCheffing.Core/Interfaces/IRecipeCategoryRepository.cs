using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.Core.Interfaces;

public interface IRecipeCategoryRepository
{
    Task<IEnumerable<RecipeCategory>> Read();
    Task<RecipeCategory?> Read(Guid id);
    Task Create(RecipeCategory category);
    Task<bool> Update(Guid id, RecipeCategory category);
    Task<bool> Delete(Guid id);
}
