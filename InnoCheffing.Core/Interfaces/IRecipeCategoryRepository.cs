using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Pagination;

namespace InnoCheffing.Core.Interfaces;

public interface IRecipeCategoryRepository
{
    Task<PagedList<RecipeCategory>> Read(RecipeCategoryParameters parameters, CancellationToken cancellationToken);
    Task<RecipeCategory?> Read(Guid id);
    Task Create(RecipeCategory category);
    Task<bool> Update(Guid id, RecipeCategory category);
    Task<bool> Delete(Guid id);
}
