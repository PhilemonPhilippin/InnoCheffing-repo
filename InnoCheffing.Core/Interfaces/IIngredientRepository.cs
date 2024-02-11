using InnoCheffing.Core.Entities;

namespace InnoCheffing.Core.Interfaces;

public interface IIngredientRepository
{
    Task<IEnumerable<Ingredient>> Read();
    Task<Ingredient> Read(Guid id);
    Task Create(Ingredient ingredient);
    Task<bool> Delete(Guid id);
    Task<bool> Update(Guid id, Ingredient ingredient);
}
