using InnoCheffing.Core.Data;
using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.Core.Repositories;

public abstract class Repository(InnoCheffingContext context)
{
    internal readonly InnoCheffingContext _context = context;
    internal static string ValidateName(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("The name must not be empty.", nameof(name));

        name = name.Trim();

        if (name.Length > 150)
            throw new ArgumentOutOfRangeException(nameof(name), "The name must not have more than 150 characters.");

        return name;
    }
}
