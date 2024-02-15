namespace InnoCheffing.Core.Entities.Pagination;

public class IngredientParameters : PaginationParameters
{
}

public class RecipeCategoryParameters : PaginationParameters
{
    public override int MaxPageSize { get; init; } = 100;
}

public class RecipeParameters : PaginationParameters
{
}