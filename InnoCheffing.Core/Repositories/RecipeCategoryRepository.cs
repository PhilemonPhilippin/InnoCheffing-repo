
using InnoCheffing.Core.Data;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Pagination;
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
        RecipeCategory? category = await _context.RecipeCategories.FindAsync(id);

        if (category is null)
            return false;

        _context.Remove(category);
        await _context.SaveChangesAsync();

        return true;
    }

    public async Task<PagedList<RecipeCategory>> Read(RecipeCategoryParameters parameters, CancellationToken cancellationToken)
    {
        IQueryable<RecipeCategory> source = _context.RecipeCategories.AsNoTracking().OrderBy(rc => rc.Name);

        PagedList<RecipeCategory> categories = await PagedList<RecipeCategory>.ToPagedList(source, parameters.PageNumber, parameters.PageSize);

        return categories;
    }

    public async Task<RecipeCategory?> Read(Guid id)
    {
        RecipeCategory? category = await _context.RecipeCategories.FindAsync(id);

        return category;
    }

    public async Task<bool> Update(Guid id, RecipeCategory category)
    {
        RecipeCategory? categoryToUpdate = await _context.RecipeCategories.FindAsync(id);

        if (categoryToUpdate is null) 
            return false;

        string categoryName = ValidateName(category.Name);

        categoryToUpdate.Name = categoryName;
        categoryToUpdate.ModifiedOn = DateTime.UtcNow;
        await _context.SaveChangesAsync();

        return true;
    }
}
