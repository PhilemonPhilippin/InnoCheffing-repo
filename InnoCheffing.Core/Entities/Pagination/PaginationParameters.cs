namespace InnoCheffing.Core.Entities.Pagination;

public abstract class PaginationParameters
{
    public int PageNumber { get; set; } = 1;
    public virtual int MaxPageSize { get; init; } = 50;
    private int _pageSize = 10;
    public int PageSize
    {
        get
        {
            return _pageSize;
        }
        set
        {
            _pageSize = value > MaxPageSize ? MaxPageSize : value;
        }
    }
}
