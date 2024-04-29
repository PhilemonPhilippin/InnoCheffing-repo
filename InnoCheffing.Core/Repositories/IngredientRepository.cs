using InnoCheffing.Core.Data;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Pagination;
using InnoCheffing.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InnoCheffing.Core.Repositories;

public class IngredientRepository(InnoCheffingContext context) : Repository<Ingredient>(context), IIngredientRepository
{
    public async Task Create(Ingredient ingredient)
    {
        string ingredientName = ValidateName(ingredient.Name);

        ingredient.Name = ingredientName;
        _context.Add(ingredient);
        await _context.SaveChangesAsync();
    }

    public async Task<PagedList<Ingredient>> Read(IngredientParameters ingredientParameters, CancellationToken cancellationToken)
    {
        IQueryable<Ingredient> source = _context.Ingredients.AsNoTracking().OrderBy(i => i.Name);

        PagedList<Ingredient> ingredients = await PagedList<Ingredient>.ToPagedList(source, ingredientParameters.PageNumber, ingredientParameters.PageSize);

        return ingredients;
    }

    public async Task<bool> Update(Guid id, Ingredient ingredient)
    {
        string ingredientName = ValidateName(ingredient.Name);

        Ingredient? ingredientToUpdate = await Read(id);

        if (ingredientToUpdate is null)
            return false;

        ingredientToUpdate.Name = ingredientName;
        ingredientToUpdate.ModifiedOn = DateTime.UtcNow;
        await _context.SaveChangesAsync();

        return true;
    }
}
