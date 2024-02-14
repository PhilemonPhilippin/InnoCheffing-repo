namespace InnoCheffing.API.Contracts;

public record IngredientDto(Guid Id, string Name);
public record RecipeCategoryDto(Guid Id, string Name);
public record RecipeDto(Guid Id, string Name, string? Description, Guid RecipeCategoryId);
