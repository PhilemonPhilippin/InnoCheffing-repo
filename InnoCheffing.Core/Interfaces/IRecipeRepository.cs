using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Pagination;

namespace InnoCheffing.Core.Interfaces;

public interface IRecipeRepository
{
    Task<PagedList<Recipe>> Read(RecipeParameters parameters, CancellationToken cancellationToken);
    Task<Recipe> Read(Guid id);
    Task Create(Recipe recipe);
}
