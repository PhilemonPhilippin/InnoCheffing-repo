namespace InnoCheffing.API.Contracts;
public record IngredientRequest(string Name);
public record RecipeCategoryRequest(string Name);
public record RecipeRequest(string Name, string? Description, Guid RecipeCategoryId);