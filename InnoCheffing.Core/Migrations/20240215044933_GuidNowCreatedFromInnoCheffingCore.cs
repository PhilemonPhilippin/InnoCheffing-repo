using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InnoCheffing.Core.Migrations
{
    /// <inheritdoc />
    public partial class GuidNowCreatedFromInnoCheffingCore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "RecipeIngredient");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "RecipeIngredient");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "RecipeIngredient",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RecipeIngredient",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }
    }
}
