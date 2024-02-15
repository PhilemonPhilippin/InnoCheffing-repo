using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Pagination;

namespace InnoCheffing.Core.Interfaces;

public interface IRecipeCategoryRepository : IRepository<RecipeCategory>
{
    Task<PagedList<RecipeCategory>> Read(RecipeCategoryParameters parameters, CancellationToken cancellationToken);
    Task Create(RecipeCategory category);
    Task<bool> Update(Guid id, RecipeCategory category);
}
