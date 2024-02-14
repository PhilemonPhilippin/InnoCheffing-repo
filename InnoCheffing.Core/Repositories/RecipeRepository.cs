using InnoCheffing.Core.Data;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Pagination;
using InnoCheffing.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InnoCheffing.Core.Repositories;

public class RecipeRepository(InnoCheffingContext context) : Repository(context), IRecipeRepository
{
    public async Task Create(Recipe recipe)
    {
        string recipeName = ValidateName(recipe.Name);
        string? description = ValidateDescription(recipe.Description);

        recipe.Name = recipeName;
        recipe.Description = description;

        _context.Add(recipe);
        await _context.SaveChangesAsync();
    }

    public async Task<Recipe> Read(Guid id)
    {
        var recipe = await _context.Recipes.FindAsync(id);

        return recipe;
    }

    public async Task<PagedList<Recipe>> Read(RecipeParameters parameters, CancellationToken cancellationToken)
    {
        IQueryable<Recipe> source = _context.Recipes.AsNoTracking().OrderBy(r => r.Name);

        PagedList<Recipe> recipes = await PagedList<Recipe>.ToPagedList(source, parameters.PageNumber, parameters.PageSize);

        return recipes;
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

}
