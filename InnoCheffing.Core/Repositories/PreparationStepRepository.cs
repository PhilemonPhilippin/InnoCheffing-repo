﻿using InnoCheffing.Core.Data;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InnoCheffing.Core.Repositories;

public class PreparationStepRepository(InnoCheffingContext context) : Repository<PreparationStep>(context), IPreparationStepRepository
{
    public async Task Create(Guid recipeId, PreparationStep preparationStep)
    {
        string stepName = ValidateName(preparationStep.Name);
        string? step = ValidateStep(preparationStep.Step);

        await ValidateRecipeId(recipeId);

        if (preparationStep.StepNumber is not null)
            await ValidateStepNumber(preparationStep.StepNumber, recipeId);

        preparationStep.Name = stepName;
        preparationStep.Step = step;

        _context.Add(preparationStep);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<PreparationStep>> ReadAll(Guid recipeId)
    {
        // Order by ascending step numbers with value first, then those with null, then order by Name.
        IEnumerable<PreparationStep> steps = await _context.PreparationSteps
            .AsNoTracking()
            .OrderByDescending(s => s.StepNumber.HasValue)
            .ThenBy(s => s.StepNumber)
            .ThenBy(s => s.Name)
            .ToListAsync();

        return steps;
    }
    public async Task<bool> Update(Guid recipeId, Guid preparationStepId, PreparationStep preparationStep)
    {
        string stepName = ValidateName(preparationStep.Name);
        string? step = ValidateStep(preparationStep.Step);

        await ValidateRecipeId(recipeId);

        if (preparationStep.StepNumber is not null)
            await ValidateStepNumber(preparationStep.StepNumber, recipeId, preparationStepId);

        PreparationStep? preparationStepToUpdate = await _context.PreparationSteps.FindAsync(preparationStepId);

        if (preparationStepToUpdate is null)
            return false;

        preparationStepToUpdate.Name = stepName;
        preparationStepToUpdate.Step = step;
        preparationStepToUpdate.StepNumber = preparationStep.StepNumber;
        preparationStepToUpdate.ModifiedOn = DateTime.UtcNow;

        await _context.SaveChangesAsync();
        return true;
    }

    private static string? ValidateStep(string? step)
    {
        if (string.IsNullOrEmpty(step))
            return step;

        step = step.Trim();

        if (step.Length > 500)
            throw new ArgumentOutOfRangeException(nameof(step), "The step must not have more than 500 characters.");

        return step;
    }

    private async Task ValidateRecipeId(Guid recipeId)
    {
        bool isRecipeIdValid = await _context.Recipes.AsNoTracking().AnyAsync(r => r.Id == recipeId);

        if (isRecipeIdValid == false)
            throw new ArgumentOutOfRangeException(nameof(recipeId), "The recipe id does not exist.");
    }

    private async Task ValidateStepNumber(int? stepNumber, Guid recipeId)
    {
        if (stepNumber <= 0)
            throw new ArgumentOutOfRangeException(nameof(stepNumber), "The step number must be greater than zero.");

        bool stepNumberExists = await _context.PreparationSteps
            .AsNoTracking()
            .AnyAsync(s => 
            s.StepNumber == stepNumber &&
            s.RecipeId == recipeId);

        // Throws exception if the step number already exists for a given recipe.
        if (stepNumberExists)
            throw new ArgumentException("The step number already exists.", nameof(stepNumber));
    }

    private async Task ValidateStepNumber(int? stepNumber, Guid recipeId, Guid preparationStepId)
    {
        if (stepNumber <= 0)
            throw new ArgumentOutOfRangeException(nameof(stepNumber), "The step number must be greater than zero.");

        bool stepNumberExists = await _context.PreparationSteps
            .AsNoTracking()
            .AnyAsync(s => 
            s.StepNumber == stepNumber && 
            s.RecipeId == recipeId && 
            s.Id != preparationStepId);

        // Throws exception if the step number already exists for another step of a given recipe.
        if (stepNumberExists)
            throw new ArgumentException("The step number already exists.", nameof(stepNumber));
    }
}
