using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Pagination;

namespace InnoCheffing.Core.Interfaces;

public interface IIngredientRepository
{
    Task<PagedList<Ingredient>> Read(IngredientParameters ingredientParameters, CancellationToken cancellationToken);
    Task<Ingredient> Read(Guid id);
    Task Create(Ingredient ingredient);
    Task<bool> Delete(Guid id);
    Task<bool> Update(Guid id, Ingredient ingredient);
}
