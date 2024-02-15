using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Pagination;

namespace InnoCheffing.Core.Interfaces;

public interface IRecipeRepository : IRepository<Recipe>
{
    Task<PagedList<Recipe>> Read(RecipeParameters parameters, CancellationToken cancellationToken);
    Task Create(Recipe recipe);
    Task<bool> Update(Guid id, Recipe recipe);
}
