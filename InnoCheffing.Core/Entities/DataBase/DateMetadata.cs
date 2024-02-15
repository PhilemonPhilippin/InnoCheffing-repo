namespace InnoCheffing.Core.Entities.DataBase;

public abstract class DateMetadata
{
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public DateMetadata()
    {
        CreatedOn = DateTime.UtcNow;
        ModifiedOn = DateTime.UtcNow;
    }
}
