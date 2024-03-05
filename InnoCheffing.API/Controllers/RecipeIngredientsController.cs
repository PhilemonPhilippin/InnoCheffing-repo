using InnoCheffing.API.Contracts;
using InnoCheffing.API.Mappers;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InnoCheffing.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecipeIngredientsController(IRecipeIngredientRepository recipeIngredientRepository) : ControllerBase
{
    private readonly IRecipeIngredientRepository _recipeIngredientRepository = recipeIngredientRepository;

    [HttpPost]
    public async Task<ActionResult<RecipeIngredientDto>> Post(RecipeIngredientRequest recipeIngredientRequest)
    {
        try
        {
            RecipeIngredient recipeIngredient = recipeIngredientRequest.MapToRecipeIngredient();

            await _recipeIngredientRepository.Create(recipeIngredient);

            RecipeIngredientDto dto = recipeIngredient.MapToDto();
            return Ok(dto);
            // TODO: Return CreatedAtAction when Get action is made
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
