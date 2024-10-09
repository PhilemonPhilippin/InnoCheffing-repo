namespace InnoCheffing.Core.Entities.Pagination;

public abstract class PaginationParameters
{
    protected abstract int MaxPageSize { get; init; }

    private int _pageNumber = 1;
    public int PageNumber
    {
        get
        {
            return _pageNumber;
        }
        set
        {
            _pageNumber = value < 1 ? 1 : value;
        }
    }
    private int _pageSize = 10;
    public int PageSize
    {
        get
        {
            return _pageSize;
        }
        set
        {
            if (value > MaxPageSize)
                _pageSize = MaxPageSize;
            else if (value <= 0)
                _pageSize = 10;
            else
                _pageSize = value;
        }
    }
}
