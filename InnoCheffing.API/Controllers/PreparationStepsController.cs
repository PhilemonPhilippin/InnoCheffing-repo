using InnoCheffing.API.Contracts;
using InnoCheffing.API.Mappers;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Exceptions;
using InnoCheffing.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InnoCheffing.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PreparationStepsController(IPreparationStepRepository preparationStepRepository) : ControllerBase
{
    private readonly IPreparationStepRepository _preparationStepRepository = preparationStepRepository;

    // Specific nested route for GetAll endpoint.
    [HttpGet("/api/recipes/{recipeId:guid}/[controller]")]
    public async Task<ActionResult<IEnumerable<PreparationStepDto>>> GetAll(Guid recipeId)
    {
        try
        {
            IEnumerable<PreparationStep> steps = await _preparationStepRepository.ReadAll(recipeId);

            if (steps.Any() == false)
                return Ok(Enumerable.Empty<PreparationStepDto>());

            IEnumerable<PreparationStepDto> dtos = steps.Select(s => s.MapToPreparationStepDto());

            return Ok(dtos);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<PreparationStepDto>> Get(Guid id)
    {
        PreparationStep? preparationStep = await _preparationStepRepository.Read(id);

        if (preparationStep is null)
            return NotFound();

        return Ok(preparationStep.MapToPreparationStepDto());
    }

    [HttpPost]
    public async Task<ActionResult<PreparationStepDto>> Post(PreparationStepRequest preparationStepRequest)
    {
        try
        {
            PreparationStep preparationStep = preparationStepRequest.MapToPreparationStep();

            await _preparationStepRepository.Create(preparationStep);

            PreparationStepDto dto = preparationStep.MapToPreparationStepDto();

            return CreatedAtAction(nameof(Get), new { id = preparationStep.Id }, dto);
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
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

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, PreparationStepRequest preparationStepRequest)
    {
        try
        {
            PreparationStep step = preparationStepRequest.MapToPreparationStep();

            bool stepUpdated = await _preparationStepRepository.Update(id, step);

            return stepUpdated ? NoContent() : NotFound();
        }
        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
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

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        bool stepDeleted = await _preparationStepRepository.Delete(id);

        return stepDeleted ? NoContent() : NotFound();
    }
}
