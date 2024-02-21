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
public class RecipesController(IRecipeRepository recipeRepository) : ControllerBase
{
    private readonly IRecipeRepository _recipeRepository = recipeRepository;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<RecipeDto>>> Get([FromQuery] RecipeParameters parameters, CancellationToken cancellationToken)
    {
        PagedList<Recipe> recipes = await _recipeRepository.Read(parameters, cancellationToken);

        var metadata = new
        {
            recipes.TotalCount,
            recipes.PageSize,
            recipes.CurrentPage,
            recipes.TotalPages,
            recipes.HasNext,
            recipes.HasPrevious
        };

        Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(metadata));

        if (parameters.PageNumber > recipes.TotalPages && recipes.TotalPages != 0)
            return NotFound("This page number does not exist.");

        if (recipes.TotalCount == 0)
            return Ok(Enumerable.Empty<RecipeDto>());

        IEnumerable<RecipeDto> dtos = recipes.Select(r => r.MapToRecipeDto());

        return Ok(dtos);
    }


    [HttpGet("{id:guid}")]
    public async Task<ActionResult<RecipeDto>> Get(Guid id)
    {
        Recipe? recipe = await _recipeRepository.Read(id);

        if (recipe is null)
            return NotFound();

        return Ok(recipe.MapToRecipeDto());
    }

    [HttpPost]
    public async Task<ActionResult<RecipeDto>> Post(RecipeRequest recipeRequest)
    {
        try
        {
            Recipe recipe = recipeRequest.MapToRecipe();

            await _recipeRepository.Create(recipe);

            RecipeDto dto = recipe.MapToRecipeDto();

            return CreatedAtAction(nameof(Get), new { id = recipe.Id }, dto);
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
    public async Task<IActionResult> Put(Guid id, RecipeRequest recipeRequest)
    {
        try
        {
            Recipe recipe = recipeRequest.MapToRecipe();

            bool recipeUpdated = await _recipeRepository.Update(id, recipe);

            return recipeUpdated ? NoContent() : NotFound();
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
        bool recipeDeleted = await _recipeRepository.Delete(id);

        return recipeDeleted ? NoContent() : NotFound();
    }
}
