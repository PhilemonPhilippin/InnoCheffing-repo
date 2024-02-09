using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCheffing.DAL.Entities;

[Table(nameof(Ingredient))]
public class Ingredient
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(150)]
    public string Name { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }

    public Ingredient()
    {
        CreatedOn = DateTime.UtcNow;
        ModifiedOn = DateTime.UtcNow;
    }
}
