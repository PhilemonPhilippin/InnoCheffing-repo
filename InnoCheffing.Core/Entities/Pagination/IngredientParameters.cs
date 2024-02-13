namespace InnoCheffing.Core.Entities.Pagination;

public class IngredientParameters : PaginationParameters
{
    public override int MaxPageSize { get; init; } = 100;
}
