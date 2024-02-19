using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.Core.Interfaces;

public interface IPreparationStepRepository : IRepository<PreparationStep>
{
    Task<IEnumerable<PreparationStep>> ReadAll(Guid recipeId);
    Task Create(Guid recipeId, PreparationStep preparationStep);
    Task<bool> Update(Guid recipeId, Guid preparationStepId,PreparationStep preparationStep);
}
