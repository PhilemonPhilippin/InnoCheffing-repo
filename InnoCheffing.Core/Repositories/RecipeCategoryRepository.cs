
using InnoCheffing.Core.Data;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InnoCheffing.Core.Repositories;

public class RecipeCategoryRepository(InnoCheffingContext context) : Repository, IRecipeCategoryRepository
{
    private readonly InnoCheffingContext _context = context;
    public async Task Create(RecipeCategory category)
    {
        string recipeCategoryName = ValidateName(category.Name);

        category.Name = recipeCategoryName;
        _context.Add(category);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<RecipeCategory>> Read()
    {
        var ingredients = await _context.RecipeCategories.AsNoTracking()
            .OrderBy(rc => rc.Name)
            .ToListAsync();

        return ingredients;
    }
}
