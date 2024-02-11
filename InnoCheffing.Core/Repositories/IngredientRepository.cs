using InnoCheffing.Core.Data;
using InnoCheffing.Core.Entities;
using InnoCheffing.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InnoCheffing.Core.Repositories;

public class IngredientRepository(InnoCheffingContext context) : IIngredientRepository
{
    private readonly InnoCheffingContext _context = context;

    public async Task Create(Ingredient ingredient)
    {
        string ingredientName = ValidateName(ingredient);

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

    public async Task<IEnumerable<Ingredient>> Read()
    {
        var ingredients = await _context.Ingredients.Take(5).ToListAsync();
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

        string ingredientName = ValidateName(ingredient);

        ingredientToUpdate.Name = ingredientName;
        ingredientToUpdate.ModifiedOn = DateTime.UtcNow;
        await _context.SaveChangesAsync();

        return true;
    }

    private static string ValidateName(Ingredient ingredient)
    {
        string ingredientName = ingredient.Name;

        if (string.IsNullOrEmpty(ingredientName))
            throw new ArgumentException($"The name is empty.", nameof(Ingredient));

        ingredientName = ingredientName.Trim();

        if (ingredientName.Length > 150)
            throw new ArgumentOutOfRangeException(nameof(Ingredient), "The name has more than 150 characters.");

        return ingredientName;
    }
}
