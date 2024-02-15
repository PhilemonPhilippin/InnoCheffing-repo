using InnoCheffing.Core.Data;
using InnoCheffing.Core.Interfaces;

namespace InnoCheffing.Core.Repositories;

public abstract class Repository<T>(InnoCheffingContext context) : IRepository<T> where T : class
{
    public readonly InnoCheffingContext _context = context;
    public string ValidateName(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("The name must not be empty.", nameof(name));

        name = name.Trim();

        if (name.Length > 150)
            throw new ArgumentOutOfRangeException(nameof(name), "The name must not have more than 150 characters.");

        return name;
    }

    public async Task<T?> Read(Guid id)
    {
        T? entity = await _context.FindAsync<T>(id);

        return entity;
    }

    public async Task<bool> Delete(Guid id)
    {
        T? entity = await _context.FindAsync<T>(id);

        if (entity is null)
            return false;

        _context.Remove(entity);
        await _context.SaveChangesAsync();

        return true;
    }
}
