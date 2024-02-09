using InnoCheffing.DAL.Data;
using InnoCheffing.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Get() 
        {
            var ingredients = _context.Ingredients.Take(5);
            if (ingredients.Any())
                return Ok(ingredients);
            else
                return NotFound();
        }

        [HttpPost]
        public IActionResult Add()
        {
            var ingredient = new Ingredient { Name = "Tomato" };
            _context.Add(ingredient);
            _context.SaveChanges();
            return Ok(ingredient);
        }
    }
}
