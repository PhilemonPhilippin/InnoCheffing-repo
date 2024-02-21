using InnoCheffing.API.Contracts;
using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.API.Mappers;

internal static class PreparationStepMappers
{
    internal static PreparationStepDto MapToPreparationStepDto(this PreparationStep step) => 
        new(step.Id, step.Name, step.StepNumber, step.Step, step.RecipeId);

    internal static PreparationStep MapToPreparationStep(this PreparationStepRequest preparationStepRequest)
    {
        return new()
        {
            Name = preparationStepRequest.Name,
            StepNumber = preparationStepRequest.StepNumber,
            Step = preparationStepRequest.Step,
            RecipeId = preparationStepRequest.RecipeId
        };
    }
}
