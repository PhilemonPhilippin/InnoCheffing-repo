using InnoCheffing.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace InnoCheffing.DAL.Data;

public class InnoCheffingContext : DbContext
{
    public InnoCheffingContext(DbContextOptions<InnoCheffingContext> options) : base(options)
    {
    }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Act> Acts { get; set; }
    public DbSet<Target> Targets { get; set; }
    public DbSet<IngredientMeasure> IngredientMeasures { get; set; }
    public DbSet<TimeMeasure> TimeMeasures { get; set; }
}
