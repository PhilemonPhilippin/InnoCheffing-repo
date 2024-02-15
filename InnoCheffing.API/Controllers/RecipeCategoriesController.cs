using InnoCheffing.API.Contracts;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Interfaces;
using InnoCheffing.API.Mappers;
using Microsoft.AspNetCore.Mvc;
using InnoCheffing.Core.Entities.Pagination;
using System.Text.Json;

namespace InnoCheffing.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecipeCategoriesController(IRecipeCategoryRepository recipeCategoryRepository) : ControllerBase
{
    private readonly IRecipeCategoryRepository _recipeCategoryRepository = recipeCategoryRepository;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<RecipeCategoryDto>>> Get([FromQuery] RecipeCategoryParameters parameters, CancellationToken cancellationToken)
    {
        PagedList<RecipeCategory> categories = await _recipeCategoryRepository.Read(parameters, cancellationToken);

        var metadata = new
        {
            categories.TotalCount,
            categories.PageSize,
            categories.CurrentPage,
            categories.TotalPages,
            categories.HasNext,
            categories.HasPrevious
        };

        Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(metadata));

        if (categories.TotalCount == 0)
            return NotFound();

        if (parameters.PageNumber > categories.TotalPages)
            return NotFound("This page number does not exist.");
           
        IEnumerable<RecipeCategoryDto> dtos = categories.Select(rc => rc.MapToCategoryDto());

        return Ok(dtos);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<RecipeCategoryDto>> Get(Guid id)
    {
        RecipeCategory? category = await _recipeCategoryRepository.Read(id);

        if (category is null)
            return NotFound();

        return Ok(category.MapToCategoryDto());
    }

    [HttpPost]
    public async Task<ActionResult<RecipeCategoryDto>> Post(RecipeCategoryRequest recipeCategoryRequest)
    {
        try
        {
            RecipeCategory category = new() { Name = recipeCategoryRequest.Name };
            
            await _recipeCategoryRepository.Create(category);

            RecipeCategoryDto dto = category.MapToCategoryDto();

            return CreatedAtAction(nameof(Get), new { id = category.Id }, dto);
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
    public async Task<IActionResult> Put(Guid id, RecipeCategoryRequest categoryRequest)
    {
        try
        {
            RecipeCategory category = new() { Name =  categoryRequest.Name };

            bool categoryUpdated = await _recipeCategoryRepository.Update(id, category);

            return categoryUpdated ? NoContent() : NotFound();
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
        bool categoryDeleted = await _recipeCategoryRepository.Delete(id);

        return categoryDeleted ? NoContent() : NotFound();
    }
}
