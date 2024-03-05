namespace InnoCheffing.API.Contracts;

public record IngredientDto(Guid Id, string Name);
public record RecipeCategoryDto(Guid Id, string Name);
public record RecipeDto(Guid Id, string Name, string? Description, Guid? RecipeCategoryId);
public record PreparationStepDto(Guid Id, string Name, int? StepNumber, string? Step, Guid RecipeId);
public record RecipeIngredientDto(Guid IngredientId, Guid RecipeId, string? IngredientQuantity);
