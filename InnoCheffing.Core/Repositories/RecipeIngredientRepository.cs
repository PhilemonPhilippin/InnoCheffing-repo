using InnoCheffing.Core.Data;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InnoCheffing.Core.Repositories;

public class RecipeIngredientRepository(InnoCheffingContext context) : IRecipeIngredientRepository
{
    private readonly InnoCheffingContext _context = context;

    public async Task Create(RecipeIngredient recipeIngredient)
    {
        string? quantity = ValidateQuantity(recipeIngredient.IngredientQuantity);

        await ValidateRecipeId(recipeIngredient.RecipeId);
        await ValidateIngredientId(recipeIngredient.IngredientId);
        await ValidateUniqueIdPair(recipeIngredient.RecipeId, recipeIngredient.IngredientId);

        recipeIngredient.IngredientQuantity = quantity;

        _context.Add(recipeIngredient);
        await _context.SaveChangesAsync();
    }

    public async Task<RecipeIngredient?> Read(Guid recipeId, Guid ingredientId)
    {
        RecipeIngredient? recipeIngredient = await _context.RecipeIngredients.FindAsync(ingredientId, recipeId);

        return recipeIngredient;
    }

    private async Task ValidateUniqueIdPair(Guid recipeId, Guid ingredientId)
    {
        bool idPairExist = await _context.RecipeIngredients
            .AsNoTracking()
            .AnyAsync(ri => ri.RecipeId == recipeId && ri.IngredientId == ingredientId);

        if (idPairExist)
            throw new ArgumentException("An association of Recipe and Ingredient already exists between these two id's.", nameof(ingredientId));
    }

    private async Task ValidateIngredientId(Guid ingredientId)
    {
        bool isIngredientIdValid = await _context.Ingredients.AsNoTracking().AnyAsync(i => i.Id == ingredientId);

        if (isIngredientIdValid == false)
            throw new ArgumentOutOfRangeException(nameof(ingredientId), "The ingredient id does not exist.");
    }

    private async Task ValidateRecipeId(Guid recipeId)
    {
        bool isRecipeIdValid = await _context.Recipes.AsNoTracking().AnyAsync(r => r.Id == recipeId);

        if (isRecipeIdValid == false)
            throw new ArgumentOutOfRangeException(nameof(recipeId), "The recipe id does not exist.");
    }

    private string ValidateQuantity(string? quantity)
    {
        if (string.IsNullOrEmpty(quantity))
            return quantity;

        quantity = quantity.Trim();

        if (quantity.Length > 150)
            throw new ArgumentOutOfRangeException(nameof(quantity), "The ingredient quantity must not have more than 150 characters.");

        return quantity;
    }
}
