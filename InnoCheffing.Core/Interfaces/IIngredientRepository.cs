using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Pagination;

namespace InnoCheffing.Core.Interfaces;

public interface IIngredientRepository : IRepository<Ingredient>
{
    Task<PagedList<Ingredient>> Read(IngredientParameters ingredientParameters, CancellationToken cancellationToken);
    Task Create(Ingredient ingredient);
    Task<bool> Update(Guid id, Ingredient ingredient);
}
