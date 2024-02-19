using InnoCheffing.Core.Data;
using InnoCheffing.Core.Interfaces;
using InnoCheffing.Core.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string environmentVariableName = "InnoCheffingConnectionString";
string connectionString = Environment.GetEnvironmentVariable(environmentVariableName, EnvironmentVariableTarget.User);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IIngredientRepository, IngredientRepository>();
builder.Services.AddScoped<IRecipeCategoryRepository, RecipeCategoryRepository>();
builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
builder.Services.AddScoped<IPreparationStepRepository, PreparationStepRepository>();
builder.Services.AddDbContext<InnoCheffingContext>(options => options.UseNpgsql(connectionString));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
