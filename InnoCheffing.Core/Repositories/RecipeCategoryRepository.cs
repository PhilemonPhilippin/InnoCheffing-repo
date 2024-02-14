
using InnoCheffing.Core.Data;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InnoCheffing.Core.Repositories;

public class RecipeCategoryRepository(InnoCheffingContext context) : Repository(context), IRecipeCategoryRepository
{
    public async Task Create(RecipeCategory category)
    {
        string recipeCategoryName = ValidateName(category.Name);

        category.Name = recipeCategoryName;
        _context.Add(category);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> Delete(Guid id)
    {
        var category = await _context.RecipeCategories.FindAsync(id);

        if (category is null)
            return false;

        _context.Remove(category);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<IEnumerable<RecipeCategory>> Read()
    {
        var ingredients = await _context.RecipeCategories.AsNoTracking()
            .OrderBy(rc => rc.Name)
            .ToListAsync();

        return ingredients;
    }

    public async Task<RecipeCategory> Read(Guid id)
    {
        var category = await _context.RecipeCategories.FindAsync(id);

        return category;
    }

    public async Task<bool> Update(Guid id, RecipeCategory category)
    {
        var categoryToUpdate = await _context.RecipeCategories.FindAsync(id);

        if (categoryToUpdate is null) 
            return false;

        string categoryName = ValidateName(category.Name);

        categoryToUpdate.Name = categoryName;
        categoryToUpdate.ModifiedOn = DateTime.UtcNow;
        await _context.SaveChangesAsync();

        return true;
    }
}
