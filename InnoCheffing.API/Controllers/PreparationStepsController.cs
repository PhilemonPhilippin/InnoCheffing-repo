using InnoCheffing.API.Contracts;
using InnoCheffing.API.Mappers;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InnoCheffing.API.Controllers;

[Route("api/recipes/{recipeId:guid}/[controller]")]
[ApiController]
public class PreparationStepsController(IPreparationStepRepository preparationStepRepository) : ControllerBase
{
    private readonly IPreparationStepRepository _preparationStepRepository = preparationStepRepository;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PreparationStepDto>>> Get(Guid recipeId)
    {
        IEnumerable<PreparationStep> steps = await _preparationStepRepository.ReadAll(recipeId);

        if (steps.Any() == false)
            return NotFound();

        IEnumerable<PreparationStepDto> dtos = steps.Select(s => s.MapToPreparationStepDto());

        return Ok(dtos);
    }

    [HttpGet("{preparationStepId:guid}")]
    public async Task<ActionResult<PreparationStepDto>> Get(Guid recipeId, Guid preparationStepId)
    {
        PreparationStep? preparationStep = await _preparationStepRepository.Read(preparationStepId);

        if (preparationStep is null)
            return NotFound();

        return Ok(preparationStep.MapToPreparationStepDto());
    }

    [HttpPost]
    public async Task<ActionResult<PreparationStepDto>> Post(Guid recipeId, PreparationStepRequest preparationStepRequest)
    {
        try
        {
            PreparationStep preparationStep = preparationStepRequest.MapToPreparationStep(recipeId);

            await _preparationStepRepository.Create(recipeId, preparationStep);

            PreparationStepDto dto = preparationStep.MapToPreparationStepDto();

            return CreatedAtAction(nameof(Get), new { recipeId, preparationStepId = preparationStep.Id }, dto);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{preparationStepId:guid}")]
    public async Task<IActionResult> Put(Guid recipeId, Guid preparationStepId, PreparationStepRequest preparationStepRequest)
    {
        try
        {
            PreparationStep step = preparationStepRequest.MapToPreparationStep(recipeId);

            bool stepUpdated = await _preparationStepRepository.Update(recipeId, preparationStepId, step);

            return stepUpdated ? NoContent() : NotFound();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{preparationStepId:guid}")]
    public async Task<IActionResult> Delete(Guid recipeId, Guid preparationStepId)
    {
        bool stepDeleted = await _preparationStepRepository.Delete(preparationStepId);

        return stepDeleted ? NoContent() : NotFound();
    }
}
