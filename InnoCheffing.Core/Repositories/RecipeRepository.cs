using InnoCheffing.Core.Data;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Pagination;
using InnoCheffing.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InnoCheffing.Core.Repositories;

public class RecipeRepository(InnoCheffingContext context) : Repository<Recipe>(context),  IRecipeRepository
{
    public async Task Create(Recipe recipe)
    {
        string recipeName = ValidateName(recipe.Name);
        string? description = ValidateDescription(recipe.Description);
        
        if (recipe.RecipeCategoryId is not null)
            await ValidateRecipeCategoryId(recipe.RecipeCategoryId);

        recipe.Name = recipeName;
        recipe.Description = description;

        _context.Add(recipe);
        await _context.SaveChangesAsync();
    }

    public async Task<PagedList<Recipe>> Read(RecipeParameters parameters, CancellationToken cancellationToken)
    {
        IQueryable<Recipe> source = _context.Recipes.AsNoTracking().OrderBy(r => r.Name);

        PagedList<Recipe> recipes = await PagedList<Recipe>.ToPagedList(source, parameters.PageNumber, parameters.PageSize);

        return recipes;
    }

    public async Task<bool> Update(Guid id, Recipe recipe)
    {
        Recipe? recipeToUpdate = await _context.Recipes.FindAsync(id);

        if (recipeToUpdate is null)
            return false;

        string recipeName = ValidateName(recipe.Name);
        string? description = ValidateDescription(recipe.Description);


        if (recipe.RecipeCategoryId is not null)
            await ValidateRecipeCategoryId(recipe.RecipeCategoryId);

        recipeToUpdate.Name = recipeName;
        recipeToUpdate.Description = description;
        recipeToUpdate.RecipeCategoryId = recipe.RecipeCategoryId;
        recipeToUpdate.ModifiedOn = DateTime.UtcNow;

        await _context.SaveChangesAsync();

        return true;
    }
    private static string? ValidateDescription(string? description)
    {
        if (string.IsNullOrEmpty(description))
            return description;

        description = description.Trim();

        if (description.Length > 500)
            throw new ArgumentOutOfRangeException(nameof(description), "The description must not have more than 500 characters.");

        return description;
    }

    private async Task ValidateRecipeCategoryId(Guid? recipeCategoryId)
    {
        RecipeCategory? recipeCategory = await _context.RecipeCategories.FindAsync(recipeCategoryId);

        if (recipeCategory is null)
            throw new ArgumentOutOfRangeException(nameof(recipeCategoryId), "The recipe category id does not exist.");
    }
}
