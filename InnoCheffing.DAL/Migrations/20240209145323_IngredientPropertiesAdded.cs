using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InnoCheffing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class IngredientPropertiesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.RenameTable(
                name: "Ingredients",
                newName: "Ingredient");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ingredient",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Ingredient",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 9, 14, 53, 23, 346, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Ingredient",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 9, 14, 53, 23, 346, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredient",
                table: "Ingredient",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredient",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Ingredient");

            migrationBuilder.RenameTable(
                name: "Ingredient",
                newName: "Ingredients");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ingredients",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(150)",
                oldMaxLength: 150);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                column: "Id");
        }
    }
}
