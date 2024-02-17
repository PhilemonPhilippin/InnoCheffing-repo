using System.ComponentModel.DataAnnotations;

namespace InnoCheffing.Core.Entities.DataBase;

public abstract class DateMetadata
{
    [Required]
    public DateTime CreatedOn { get; set; }
    [Required]
    public DateTime ModifiedOn { get; set; }
    public DateMetadata()
    {
        CreatedOn = DateTime.UtcNow;
        ModifiedOn = DateTime.UtcNow;
    }
}
