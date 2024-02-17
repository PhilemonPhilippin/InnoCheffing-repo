using InnoCheffing.Core.Entities.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace InnoCheffing.Core.Data;

public class InnoCheffingContext : DbContext
{
    public InnoCheffingContext(DbContextOptions<InnoCheffingContext> options) : base(options)
    {
    }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<RecipeCategory> RecipeCategories { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
    public DbSet<PreparationStep> PreparationSteps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Composite PK
        modelBuilder.Entity<RecipeIngredient>().HasKey(ir => new { ir.IngredientId, ir.RecipeId });

        // Many-to-Many
        modelBuilder.Entity<RecipeIngredient>()
            .HasOne(ir => ir.Ingredient)
            .WithMany(ir => ir.RecipeIngredients)
            .HasForeignKey(ir => ir.IngredientId);

        modelBuilder.Entity<RecipeIngredient>()
            .HasOne(ir => ir.Recipe)
            .WithMany(ir => ir.RecipeIngredients)
            .HasForeignKey(ir => ir.RecipeId);

        // Unique
        modelBuilder.Entity<PreparationStep>().HasIndex(ps => ps.StepNumber).IsUnique();

        // Check Constraint
        modelBuilder.Entity<PreparationStep>().ToTable(table => table.HasCheckConstraint("CK_PreparationStep_StepNumber", "\"StepNumber\" > 0"));
    }
}
