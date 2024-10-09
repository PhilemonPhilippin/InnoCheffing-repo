namespace InnoCheffing.Core.Entities.Pagination;

public class IngredientParameters : PaginationParameters
{
    protected override int MaxPageSize { get; init; } = 50;
}

public class RecipeCategoryParameters : PaginationParameters
{
    protected override int MaxPageSize { get; init; } = 100;
}

public class RecipeParameters : PaginationParameters
{
    protected override int MaxPageSize { get; init; } = 50;
}