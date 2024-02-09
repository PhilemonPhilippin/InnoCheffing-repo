using InnoCheffing.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace InnoCheffing.DAL.Data;

public class InnoCheffingContext : DbContext
{
    public InnoCheffingContext(DbContextOptions<InnoCheffingContext> options) : base(options)
    {
    }
    public DbSet<Ingredient> Ingredients { get; set; }
}
