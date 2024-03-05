using InnoCheffing.API.Tools;
using System.ComponentModel.DataAnnotations;

namespace InnoCheffing.API.Contracts;
public record IngredientRequest([Required][MaxLength(150)] string Name);
public record RecipeCategoryRequest([Required][MaxLength(150)] string Name);
public record RecipeRequest([Required][MaxLength(150)] string Name, [MaxLength(500)] string? Description, Guid? RecipeCategoryId);
public record PreparationStepRequest([Required][MaxLength(150)] string Name,[StepNumber] int? StepNumber, [MaxLength(500)] string? Step, [Required] Guid RecipeId);
public record RecipeIngredientRequest([Required] Guid IngredientId, [Required] Guid RecipeId, [MaxLength(150)] string? IngredientQuantity);