using System.ComponentModel.DataAnnotations;

namespace InnoCheffing.Core.Entities.DataBase;

public abstract class Entity : DateMetadata
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(150)]
    public string Name { get; set; }
    public Entity()
    {
        Id = Guid.NewGuid();
    }
}
