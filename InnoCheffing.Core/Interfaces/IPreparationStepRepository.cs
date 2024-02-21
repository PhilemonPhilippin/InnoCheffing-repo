using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.Core.Interfaces;

public interface IPreparationStepRepository : IRepository<PreparationStep>
{
    Task<IEnumerable<PreparationStep>> ReadAll(Guid recipeId);
    Task Create(PreparationStep preparationStep);
    Task<bool> Update(Guid preparationStepId, PreparationStep preparationStep);
}
