using InnoCheffing.Core.Data;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Interfaces;

namespace InnoCheffing.Core.Repositories;

public class PreparationStepRepository(InnoCheffingContext context) : Repository<PreparationStep>(context), IPreparationStepRepository
{
}
