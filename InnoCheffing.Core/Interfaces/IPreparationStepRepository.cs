using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.Core.Interfaces;

public interface IPreparationStepRepository
{
    Task<PreparationStep> Read(Guid id);
}
