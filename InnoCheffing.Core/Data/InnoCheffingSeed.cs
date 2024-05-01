using InnoCheffing.Core.Entities.DataBase;
using Microsoft.EntityFrameworkCore;

namespace InnoCheffing.Core.Data;

public static class InnoCheffingSeed
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        SeedGenerator seed = new();

        modelBuilder.Entity<Ingredient>().HasData(seed.Ingredients);
        modelBuilder.Entity<RecipeCategory>().HasData(seed.RecipeCategories);
        modelBuilder.Entity<Recipe>().HasData(seed.Recipes);
        modelBuilder.Entity<RecipeIngredient>().HasData(seed.RecipeIngredients);
        modelBuilder.Entity<PreparationStep>().HasData(seed.PreparationSteps);
    }
}
