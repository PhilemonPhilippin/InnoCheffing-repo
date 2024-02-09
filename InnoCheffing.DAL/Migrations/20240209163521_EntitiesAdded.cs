using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InnoCheffing.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Ingredient",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 2, 9, 14, 53, 23, 346, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Ingredient",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2024, 2, 9, 14, 53, 23, 346, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.CreateTable(
                name: "Act",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Act", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientMeasure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientMeasure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Target",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Target", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeMeasure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeMeasure", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Act");

            migrationBuilder.DropTable(
                name: "IngredientMeasure");

            migrationBuilder.DropTable(
                name: "Target");

            migrationBuilder.DropTable(
                name: "TimeMeasure");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Ingredient",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 9, 14, 53, 23, 346, DateTimeKind.Utc).AddTicks(1950),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Ingredient",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 9, 14, 53, 23, 346, DateTimeKind.Utc).AddTicks(1669),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }
    }
}
