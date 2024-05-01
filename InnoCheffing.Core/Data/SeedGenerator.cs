using InnoCheffing.Core.Entities.DataBase;

namespace InnoCheffing.Core.Data;

public class SeedGenerator
{
    private readonly Random _randomGenerator;
    public List<Ingredient> Ingredients { get; init; }
    public List<RecipeIngredient> RecipeIngredients { get; init; }
    public List<RecipeCategory> RecipeCategories { get; init; }
    public List<Recipe> Recipes { get; init; }
    public List<PreparationStep> PreparationSteps { get; init; }
    public SeedGenerator()
    {
        _randomGenerator = new Random();
        Ingredients = CreateIngredients();
        RecipeCategories = CreateRecipeCategories();
        Recipes = CreateRecipes();
        RecipeIngredients = CreateRecipeIngredients();
        PreparationSteps = CreatePreparationSteps();
    }

    public List<PreparationStep> CreatePreparationSteps()
    {
        List<PreparationStep> retval = new();
        // I give only the step numbers "1" and "2" to each recipe.
        int count = 1;
        Guid[] recipeIds = Recipes.Select(x => x.Id).ToArray();
        // And I give only two preparation steps to each recipe.
        int recipeIndex = 0;
        for (int i = 1; i <= 50; i++)
        {
            PreparationStep preparationStepToAdd = new()
            {
                Name = $"Preparation step nb°{i}",
                Step = "Cook it",
                StepNumber = count,
                RecipeId = recipeIds[recipeIndex]
            };
            retval.Add(preparationStepToAdd);

            if (i % 2 == 0)
            {
                count = 1;
                recipeIndex++;
            }
            else
                count++;
        }

        return retval;
    }

    public List<Ingredient> CreateIngredients()
    {
        List<Ingredient> retval = new();
        for (int i = 1; i <= 50; i++)
        {
            Ingredient ingredientToAdd = new Ingredient()
            {
                Name = $"Ingredient nb°{i}"
            };
            retval.Add(ingredientToAdd);
        }
        return retval;
    }
    public List<RecipeIngredient> CreateRecipeIngredients()
    {
        List<RecipeIngredient> retval = new();
        Guid[] recipeIds = Recipes.Select(x => x.Id).ToArray();
        for (int i = 0; i < Ingredients.Count; i++)
        {
            int recipeRandomIndex = _randomGenerator.Next(0, recipeIds.Length);
            RecipeIngredient recipeIngredientToAdd = new()
            {
                IngredientId = Ingredients[i].Id,
                RecipeId = Recipes[recipeRandomIndex].Id,
                IngredientQuantity = NextQuantity()
            };
            retval.Add(recipeIngredientToAdd);
        }
        return retval;
    }
    public List<RecipeCategory> CreateRecipeCategories()
    {
        List<RecipeCategory> retval = new();
        for (int i = 1; i <= 10; i++)
        {
            RecipeCategory recipeCategoryToAdd = new RecipeCategory()
            {
                Name = $"Recipe category nb°{i}"
            };
            retval.Add(recipeCategoryToAdd);
        }
        return retval;
    }

    public List<Recipe> CreateRecipes()
    {
        List<Recipe> retval = new();
        Guid[] recipeCategoryIds = RecipeCategories.Select(rc => rc.Id).ToArray();
        for (int i = 1; i <= 25; i++)
        {
            int recipeCategoryRandomIndex = _randomGenerator.Next(0, recipeCategoryIds.Length); 
            Recipe recipeToAdd = new()
            {
                Name = $"Recipe nb°{i}",
                Description = $"This is a good recipe and it is the number {i}",
                RecipeCategoryId = RecipeCategories[recipeCategoryRandomIndex].Id
            };
            retval.Add(recipeToAdd);
        }
        return retval;
    }

    private string NextQuantity()
    {
        string[] measures =
        {
           "g", "ml"
        };

        return _randomGenerator.Next(100, 500).ToString() + " " + measures[_randomGenerator.Next(0, 2)];
    }
}
