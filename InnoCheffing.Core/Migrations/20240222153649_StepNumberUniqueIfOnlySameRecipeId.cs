using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InnoCheffing.Core.Migrations
{
    /// <inheritdoc />
    public partial class StepNumberUniqueIfOnlySameRecipeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PreparationStep_StepNumber",
                table: "PreparationStep");

            migrationBuilder.CreateIndex(
                name: "IX_PreparationStep_StepNumber_RecipeId",
                table: "PreparationStep",
                columns: new[] { "StepNumber", "RecipeId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PreparationStep_StepNumber_RecipeId",
                table: "PreparationStep");

            migrationBuilder.CreateIndex(
                name: "IX_PreparationStep_StepNumber",
                table: "PreparationStep",
                column: "StepNumber",
                unique: true);
        }
    }
}
