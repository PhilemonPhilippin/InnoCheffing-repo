
namespace InnoCheffing.Core.Interfaces;

public interface IRepository<T>
{
    Task<T?> Read(Guid id);
    Task<bool> Delete(Guid id);
    string ValidateName(string name);
}
