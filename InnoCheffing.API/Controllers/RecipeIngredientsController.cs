using InnoCheffing.API.Contracts;
using InnoCheffing.API.Mappers;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Exceptions;
using InnoCheffing.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InnoCheffing.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecipeIngredientsController(IRecipeIngredientRepository recipeIngredientRepository) : ControllerBase
{
    private readonly IRecipeIngredientRepository _recipeIngredientRepository = recipeIngredientRepository;


    [HttpGet("{recipeId:guid}")]
    public async Task<ActionResult<IEnumerable<RecipeIngredientDto>>> Get(Guid recipeId)
    {
        try
        {
            IEnumerable<RecipeIngredient> recipeIngredients = await _recipeIngredientRepository.Read(recipeId);

            if (recipeIngredients.Any() == false)
                return Ok(Enumerable.Empty<RecipeIngredientDto>());

            IEnumerable<RecipeIngredientDto> dtos = recipeIngredients.Select(ri => ri.MapToDto());

            return Ok(dtos);
        }

        catch (NotFoundException ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpGet("{recipeId:guid}/{ingredientId:guid}")]
    public async Task<ActionResult<RecipeIngredientDto>> Get(Guid recipeId, Guid ingredientId)
    {
        RecipeIngredient? recipeIngredient = await _recipeIngredientRepository.Read(recipeId, ingredientId);

        if (recipeIngredient is null)
            return NotFound();

        return Ok(recipeIngredient.MapToDto());
    }

    [HttpPost]
    public async Task<ActionResult<RecipeIngredientDto>> Post(RecipeIngredientRequest recipeIngredientRequest)
    {
        try
        {
            RecipeIngredient recipeIngredient = recipeIngredientRequest.MapToRecipeIngredient();

            await _recipeIngredientRepository.Create(recipeIngredient);

            RecipeIngredientDto dto = recipeIngredient.MapToDto();

            return CreatedAtAction(nameof(Get), new { recipeId = recipeIngredient.RecipeId, ingredientId = recipeIngredient.IngredientId }, dto);
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
}
