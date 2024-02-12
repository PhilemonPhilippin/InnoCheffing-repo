using InnoCheffing.API.Contracts;
using InnoCheffing.Core.Entities.DataBase;
using InnoCheffing.Core.Entities.Pagination;
using InnoCheffing.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace InnoCheffing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientsController(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingredient>>> Get([FromQuery] IngredientParameters ingredientParameters, CancellationToken cancellationToken)
        {
            var ingredients = await _ingredientRepository.Read(ingredientParameters, cancellationToken);

            var metadata = new
            {
                ingredients.TotalCount,
                ingredients.PageSize,
                ingredients.CurrentPage,
                ingredients.TotalPages,
                ingredients.HasNext,
                ingredients.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));

            if (ingredients.TotalCount > 0)
                return Ok(ingredients);
            else
                return NotFound();
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Ingredient>> Get(Guid id)
        {
            var ingredient = await _ingredientRepository.Read(id);

            if (ingredient is null)
                return NotFound();
            else
                return Ok(ingredient);
        }

        [HttpPost]
        public async Task<ActionResult<Ingredient>> Post(IngredientRequest ingredientRequest)
        {
            try
            {
                Ingredient ingredient = new() { Name = ingredientRequest.Name };

                await _ingredientRepository.Create(ingredient);

                return CreatedAtAction(nameof(Get), new { id = ingredient.Id }, ingredient);
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
        public async Task<ActionResult> Put(Guid id, IngredientRequest ingredientRequest)
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
}
