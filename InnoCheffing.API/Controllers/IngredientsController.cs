using InnoCheffing.API.Contracts;
using InnoCheffing.DAL.Data;
using InnoCheffing.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InnoCheffing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        protected readonly InnoCheffingContext _context;
        public IngredientsController(InnoCheffingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingredient>>> Get() 
        {
            var ingredients = await _context.Ingredients.Take(5).ToListAsync();

            if (ingredients.Count > 0)
                return Ok(ingredients);
            else
                return NotFound();
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Ingredient>> Get(Guid id)
        {
            var ingredient = await _context.Ingredients.FindAsync(id);

            if (ingredient is null)
                return NotFound();
            else
                return Ok(ingredient);
        }

        [HttpPost]
        public async Task<ActionResult<Ingredient>> Post(IngredientRequest ingredientRequest)
        {
            string ingredientName = ingredientRequest.Name;

            if (string.IsNullOrEmpty(ingredientName))
                return BadRequest($"The {nameof(Ingredient)} name is empty.");

            ingredientName = ingredientName.Trim();

            if (ingredientName.Length > 150)
                return BadRequest($"The {nameof(Ingredient)} name has more than 150 chars.");

            Ingredient ingredient = new() { Name = ingredientName };

            _context.Add(ingredient);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = ingredient.Id }, ingredient);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult> Put(Guid id, IngredientRequest ingredientRequest)
        {
            var ingredient = await _context.Ingredients.FindAsync(id);

            if (ingredient is null)
            {
                return NotFound();
            }
            else
            {
                string ingredientName = ingredientRequest.Name;

                if (string.IsNullOrEmpty(ingredientName))
                    return BadRequest($"The {nameof(Ingredient)} name is empty.");

                ingredientName = ingredientName.Trim();

                if (ingredientName.Length > 150)
                    return BadRequest($"The {nameof(Ingredient)} name has more than 150 chars.");

                ingredient.Name = ingredientRequest.Name;
                ingredient.ModifiedOn = DateTime.UtcNow;
                await _context.SaveChangesAsync();

                return NoContent();
            }
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var ingredient = await _context.Ingredients.FindAsync(id);

            if (ingredient is null)
            {
                return NotFound();
            }
            else
            {
                _context.Remove(ingredient);
                await _context.SaveChangesAsync();
                return NoContent();
            }
        }
    }
}
