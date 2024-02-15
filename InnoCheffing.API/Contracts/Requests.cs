using System.ComponentModel.DataAnnotations;

namespace InnoCheffing.API.Contracts;
public record IngredientRequest([Required][MaxLength(150)] string Name);
public record RecipeCategoryRequest([Required][MaxLength(150)] string Name);
public record RecipeRequest([Required][MaxLength(150)] string Name, [MaxLength(500)] string? Description,[Required] Guid RecipeCategoryId);