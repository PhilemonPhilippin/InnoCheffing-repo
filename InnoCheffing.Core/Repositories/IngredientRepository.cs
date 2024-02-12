using InnoCheffing.Core.Data;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Pagination;
using InnoCheffing.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InnoCheffing.Core.Repositories;

public class IngredientRepository(InnoCheffingContext context) : Repository, IIngredientRepository
{
    private readonly InnoCheffingContext _context = context;

    public async Task Create(Ingredient ingredient)
    {
        string ingredientName = ValidateName(ingredient.Name);

        ingredient.Name = ingredientName;
        _context.Add(ingredient);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> Delete(Guid id)
    {
        var ingredient = await _context.Ingredients.FindAsync(id);

        if (ingredient is null)
            return false;

        _context.Remove(ingredient);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<PagedList<Ingredient>> Read(IngredientParameters ingredientParameters, CancellationToken cancellationToken)
    {
        var source = _context.Ingredients.AsNoTracking().OrderBy(i => i.Name);

        PagedList<Ingredient> ingredients = await PagedList<Ingredient>.ToPagedList(source, ingredientParameters.PageNumber, ingredientParameters.PageSize);

        return ingredients;
    }
    
    public async Task<Ingredient> Read(Guid id)
    {
        var ingredient = await _context.Ingredients.FindAsync(id);
        return ingredient;
    }

    public async Task<bool> Update(Guid id, Ingredient ingredient)
    {
        var ingredientToUpdate = await _context.Ingredients.FindAsync(id);

        if (ingredientToUpdate is null)
            return false;

        string ingredientName = ValidateName(ingredient.Name);

        ingredientToUpdate.Name = ingredientName;
        ingredientToUpdate.ModifiedOn = DateTime.UtcNow;
        await _context.SaveChangesAsync();

        return true;
    }
}
