using InnoCheffing.API.Contracts;
using InnoCheffing.API.Mappers;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Pagination;
using InnoCheffing.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace InnoCheffing.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IngredientsController(IIngredientRepository ingredientRepository) : ControllerBase
{
    private readonly IIngredientRepository _ingredientRepository = ingredientRepository;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<IngredientDto>>> Get([FromQuery] IngredientParameters ingredientParameters, CancellationToken cancellationToken)
    {
        PagedList<Ingredient> ingredients = await _ingredientRepository.Read(ingredientParameters, cancellationToken);

        var metadata = new
        {
            ingredients.TotalCount,
            ingredients.PageSize,
            ingredients.CurrentPage,
            ingredients.TotalPages,
            ingredients.HasNext,
            ingredients.HasPrevious
        };

        Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(metadata));

        if (ingredientParameters.PageNumber > ingredients.TotalPages && ingredients.TotalPages != 0)
            return NotFound("This page number does not exist.");

        if (ingredients.TotalCount == 0)
            return Ok(Enumerable.Empty<IngredientDto>());

        IEnumerable<IngredientDto> dtos = ingredients.Select(i => i.MapToIngredientDto());

        return Ok(dtos);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<IngredientDto>> Get(Guid id)
    {
        Ingredient? ingredient = await _ingredientRepository.Read(id);

        if (ingredient is null)
            return NotFound();

        return Ok(ingredient.MapToIngredientDto());
    }

    [HttpPost]
    public async Task<ActionResult<IngredientDto>> Post(IngredientRequest ingredientRequest)
    {
        try
        {
            Ingredient ingredient = new() { Name = ingredientRequest.Name };

            await _ingredientRepository.Create(ingredient);

            IngredientDto dto = ingredient.MapToIngredientDto();

            return CreatedAtAction(nameof(Get), new { id = ingredient.Id }, dto);
        }
        // TODO: Is this catch really needed ? I do return BadRequest(ex.Message) anyway...
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
    public async Task<IActionResult> Put(Guid id, IngredientRequest ingredientRequest)
    {
        try
        {
            Ingredient ingredient = new() { Name = ingredientRequest.Name };

            bool ingredientUpdated = await _ingredientRepository.Update(id, ingredient);

            return ingredientUpdated ? NoContent() : NotFound();
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
        bool ingredientDeleted = await _ingredientRepository.Delete(id);

        return ingredientDeleted ? NoContent() : NotFound();
    }
}
