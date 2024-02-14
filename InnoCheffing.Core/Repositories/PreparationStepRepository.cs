using InnoCheffing.Core.Data;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Interfaces;

namespace InnoCheffing.Core.Repositories;

public class PreparationStepRepository(InnoCheffingContext context) : Repository(context), IPreparationStepRepository
{
    public async Task<PreparationStep> Read(Guid id)
    {
        var preparationStep = await _context.PreparationSteps.FindAsync(id);

        throw new NotImplementedException();
    }
}
