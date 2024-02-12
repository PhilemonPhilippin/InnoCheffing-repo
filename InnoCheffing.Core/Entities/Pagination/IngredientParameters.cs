namespace InnoCheffing.Core.Entities.Pagination;

public class IngredientParameters : PaginationParameters
{
    private const int _maxPageSize = 50;
    public override int MaxPageSize
    {
        get { return _maxPageSize; }
    }
}
