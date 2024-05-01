using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InnoCheffing.Core.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("0081bc3f-d0ee-4cd7-8d24-ded5a44d3d9a"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2517), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2518), "Ingredient nb°16" },
                    { new Guid("05716eea-e8a7-4830-9646-f3cf97357301"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2535), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2535), "Ingredient nb°29" },
                    { new Guid("0b9f4368-3096-40a7-aaf4-032d79f1625f"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2532), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2532), "Ingredient nb°26" },
                    { new Guid("0db6c695-371c-4913-9312-8186ad3a6b2b"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2544), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2544), "Ingredient nb°36" },
                    { new Guid("12becc48-269b-4c81-970b-ddd2f7bdfce3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2513), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2513), "Ingredient nb°12" },
                    { new Guid("13881b4e-a800-4fac-bce4-1ffb9c067fc3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2551), "Ingredient nb°41" },
                    { new Guid("1f8d0a6d-23e6-4a21-9409-2ae72c9ac48f"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2552), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2553), "Ingredient nb°43" },
                    { new Guid("255884f5-b685-4272-87dd-e7df4891d8bb"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2538), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2538), "Ingredient nb°32" },
                    { new Guid("3239b4bf-cd50-4d89-9a54-c5b9d86bdbf5"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2499), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2499), "Ingredient nb°5" },
                    { new Guid("32f5786f-a6f0-4246-8c87-872bda815a04"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2537), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2537), "Ingredient nb°31" },
                    { new Guid("372309da-d077-45fd-968a-c12cd88d6077"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2501), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2501), "Ingredient nb°6" },
                    { new Guid("375587bb-34c1-41da-9c5b-a7116b1b0299"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2515), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2515), "Ingredient nb°14" },
                    { new Guid("38552395-f22f-42db-b550-7a90630034fb"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2504), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2504), "Ingredient nb°8" },
                    { new Guid("38ca97dd-0c37-4994-812e-dc5411b65303"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2507), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2507), "Ingredient nb°9" },
                    { new Guid("44c7bc6f-5957-4217-9145-3eff5a6d4512"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2545), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2545), "Ingredient nb°37" },
                    { new Guid("46d0c984-705e-45c9-a71f-6c4c80856930"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2542), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2542), "Ingredient nb°34" },
                    { new Guid("549b224c-5977-4bbc-b9f3-f365b69f6931"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2533), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2533), "Ingredient nb°27" },
                    { new Guid("5aa6ee85-1fde-4b0f-9595-1d9104336468"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2589), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2589), "Ingredient nb°50" },
                    { new Guid("5afa2a01-831b-427c-b7e8-1ac415925f7d"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2514), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2514), "Ingredient nb°13" },
                    { new Guid("5c186316-8f25-4d97-a83e-fd10fe6c668f"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2531), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2531), "Ingredient nb°25" },
                    { new Guid("5fa70ef5-cb56-4d23-a789-04cc243ed861"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2554), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2555), "Ingredient nb°45" },
                    { new Guid("69d96265-2d9a-495f-93bd-232242e98669"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2555), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2556), "Ingredient nb°46" },
                    { new Guid("6b28816a-8818-472e-93fc-6f0ffc0fbf65"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2502), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2503), "Ingredient nb°7" },
                    { new Guid("6c4e74ba-4a1f-44ed-b48b-3b8ed5139213"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2494), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2494), "Ingredient nb°2" },
                    { new Guid("6cd57ab9-87c9-4ec6-85f0-2c28d9a9a34d"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2584), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2584), "Ingredient nb°47" },
                    { new Guid("6ffa1f53-3b5e-48cb-93ec-e6d467a9e5f0"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2524), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2524), "Ingredient nb°20" },
                    { new Guid("71d2b2f2-ce0e-4b9b-a5ac-bab2742173b2"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2534), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2534), "Ingredient nb°28" },
                    { new Guid("787e9016-4122-461e-8c04-695a057eb194"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2526), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2526), "Ingredient nb°22" },
                    { new Guid("7c2f69bc-175f-4f88-a6ea-736f799023a1"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2551), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2552), "Ingredient nb°42" },
                    { new Guid("81fd9455-4599-482d-8ca0-96a2a8e90e44"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2525), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2525), "Ingredient nb°21" },
                    { new Guid("8b5a4d1c-f8ee-4c22-9bdc-176dad05ddcb"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2553), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2554), "Ingredient nb°44" },
                    { new Guid("91e38179-5d5e-4fc1-9cb7-9482d775cdd4"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2547), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2547), "Ingredient nb°39" },
                    { new Guid("93855115-cc33-4755-b8ec-0bd1aaa783d2"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2546), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2546), "Ingredient nb°38" },
                    { new Guid("94ff1b26-33a5-4d29-aad4-1846538c37c9"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2548), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2548), "Ingredient nb°40" },
                    { new Guid("99efa985-85ac-4b3c-a55f-7498ae862aa4"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2529), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2529), "Ingredient nb°24" },
                    { new Guid("a82fe951-8233-4a1a-b0ee-518e78f286ba"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2516), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2516), "Ingredient nb°15" },
                    { new Guid("ad2d9a85-f6b4-43eb-9715-7801b0f95c4f"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2527), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2528), "Ingredient nb°23" },
                    { new Guid("b84169d2-8e9b-4902-99e6-bccc1f39a840"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2520), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2520), "Ingredient nb°17" },
                    { new Guid("badbfd2c-b715-4162-9d22-fac0ed14e18b"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2585), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2585), "Ingredient nb°48" },
                    { new Guid("bb572009-700e-4afa-9108-44f49840c0e0"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2540), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2540), "Ingredient nb°33" },
                    { new Guid("bfc3e3d4-8282-44e9-b190-2c828e451b9e"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2588), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2588), "Ingredient nb°49" },
                    { new Guid("c54800ec-5e30-404c-8a4d-8a1d6a300dea"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2543), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2543), "Ingredient nb°35" },
                    { new Guid("ce67cbcd-2979-41ba-95d6-19beec2a862d"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2523), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2523), "Ingredient nb°19" },
                    { new Guid("d22c0e5a-cfcb-4683-bee9-e6d9041e8b54"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2496), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2496), "Ingredient nb°3" },
                    { new Guid("dbfbfae8-0bea-4622-886e-5257149028b5"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2497), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2497), "Ingredient nb°4" },
                    { new Guid("dd2c968e-f97d-41af-82d9-f885f885bba6"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2466), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2468), "Ingredient nb°1" },
                    { new Guid("e366a63d-c230-4182-93d6-747de780f33a"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2511), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2511), "Ingredient nb°11" },
                    { new Guid("ec31fa8a-3c8c-4447-a45d-b9b002e5f3ae"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2522), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2522), "Ingredient nb°18" },
                    { new Guid("ee4abc1e-5b56-4549-97d2-6938d5e2b093"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2536), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2536), "Ingredient nb°30" },
                    { new Guid("f1c9af2f-06a7-42c7-ba8f-fd32d438e512"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2508), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2509), "Ingredient nb°10" }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategory",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("1519cde9-bb2f-4794-a70d-2ccc51f69677"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2599), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2599), "Recipe category nb°5" },
                    { new Guid("444d5ac7-2715-45a9-a7c5-ec6d17e37615"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2602), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2602), "Recipe category nb°7" },
                    { new Guid("4d287bbb-b688-4d11-82dd-0d75b1108cdc"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2600), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2600), "Recipe category nb°6" },
                    { new Guid("50a35183-8609-437d-8ffd-8498efd66540"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2592), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2592), "Recipe category nb°1" },
                    { new Guid("54780721-f126-41bc-9b56-d5835c2b1b8d"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2603), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2604), "Recipe category nb°8" },
                    { new Guid("59145dc4-1a25-4651-b2ec-9ce098fdc00b"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2605), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2605), "Recipe category nb°9" },
                    { new Guid("81eca648-4396-4b46-aa47-fdf235d53f96"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2595), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2595), "Recipe category nb°2" },
                    { new Guid("c5102b51-bf2a-47e5-aee2-43f6409f8d21"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2598), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2598), "Recipe category nb°4" },
                    { new Guid("c6543897-f556-4cba-b0cb-703baf76d8fc"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2596), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2597), "Recipe category nb°3" },
                    { new Guid("dfb15546-4117-4c55-b983-30a5d67acd3a"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2606), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2606), "Recipe category nb°10" }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CreatedOn", "Description", "ModifiedOn", "Name", "RecipeCategoryId" },
                values: new object[,]
                {
                    { new Guid("16dfbd83-e953-4abd-a489-741df71197c6"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2677), "This is a good recipe and it is the number 7", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2677), "Recipe nb°7", new Guid("81eca648-4396-4b46-aa47-fdf235d53f96") },
                    { new Guid("1c32744a-4296-4812-a823-22679dafa728"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2674), "This is a good recipe and it is the number 5", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2674), "Recipe nb°5", new Guid("dfb15546-4117-4c55-b983-30a5d67acd3a") },
                    { new Guid("27f4bdc6-96d5-4e52-be8b-ae5e2f531621"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2696), "This is a good recipe and it is the number 18", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2697), "Recipe nb°18", new Guid("dfb15546-4117-4c55-b983-30a5d67acd3a") },
                    { new Guid("2bbe1f1b-8011-438f-887b-9d0dcb4f5b16"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2689), "This is a good recipe and it is the number 13", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2689), "Recipe nb°13", new Guid("1519cde9-bb2f-4794-a70d-2ccc51f69677") },
                    { new Guid("31fef45d-618e-4215-a931-52a3970c06f5"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2726), "This is a good recipe and it is the number 20", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2726), "Recipe nb°20", new Guid("54780721-f126-41bc-9b56-d5835c2b1b8d") },
                    { new Guid("3a050935-9428-4529-bc1a-c77cd83807a3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2669), "This is a good recipe and it is the number 3", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2669), "Recipe nb°3", new Guid("c6543897-f556-4cba-b0cb-703baf76d8fc") },
                    { new Guid("4d1f0d33-05a4-4bc6-83e2-5716a4e34d46"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2682), "This is a good recipe and it is the number 10", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2683), "Recipe nb°10", new Guid("dfb15546-4117-4c55-b983-30a5d67acd3a") },
                    { new Guid("4e6362d5-bffc-4b93-976a-5b265deb1aa0"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2685), "This is a good recipe and it is the number 11", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2685), "Recipe nb°11", new Guid("54780721-f126-41bc-9b56-d5835c2b1b8d") },
                    { new Guid("6bd623bd-7740-43b9-a715-fdd8d3eafdba"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2679), "This is a good recipe and it is the number 8", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2679), "Recipe nb°8", new Guid("50a35183-8609-437d-8ffd-8498efd66540") },
                    { new Guid("6c00e52f-d722-4a38-b6a2-488097c8a172"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2729), "This is a good recipe and it is the number 21", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2729), "Recipe nb°21", new Guid("c5102b51-bf2a-47e5-aee2-43f6409f8d21") },
                    { new Guid("6e6ce102-a213-40c2-81fe-7f8f2c7266f5"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2735), "This is a good recipe and it is the number 24", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2736), "Recipe nb°24", new Guid("4d287bbb-b688-4d11-82dd-0d75b1108cdc") },
                    { new Guid("7e555f89-5dc0-4adc-a245-5a3254de1ccd"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2686), "This is a good recipe and it is the number 12", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2686), "Recipe nb°12", new Guid("54780721-f126-41bc-9b56-d5835c2b1b8d") },
                    { new Guid("8bf17ef8-3866-4e85-942a-d572c71bffa3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2694), "This is a good recipe and it is the number 17", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2695), "Recipe nb°17", new Guid("4d287bbb-b688-4d11-82dd-0d75b1108cdc") },
                    { new Guid("984f0cd5-6ba6-4923-9e15-08ea713367c0"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2660), "This is a good recipe and it is the number 1", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2660), "Recipe nb°1", new Guid("59145dc4-1a25-4651-b2ec-9ce098fdc00b") },
                    { new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2681), "This is a good recipe and it is the number 9", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2681), "Recipe nb°9", new Guid("dfb15546-4117-4c55-b983-30a5d67acd3a") },
                    { new Guid("9e697c99-a30e-40e7-8a62-4d8e22c8d939"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2731), "This is a good recipe and it is the number 22", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2731), "Recipe nb°22", new Guid("1519cde9-bb2f-4794-a70d-2ccc51f69677") },
                    { new Guid("ba7f7595-ac84-4566-b16a-bfeebc07df3d"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2676), "This is a good recipe and it is the number 6", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2676), "Recipe nb°6", new Guid("81eca648-4396-4b46-aa47-fdf235d53f96") },
                    { new Guid("be9c6afc-5bb0-4733-be3e-3762e2b62232"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2737), "This is a good recipe and it is the number 25", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2737), "Recipe nb°25", new Guid("c6543897-f556-4cba-b0cb-703baf76d8fc") },
                    { new Guid("c32eeeb2-ed08-4547-bc5c-6f3a2f18e6e7"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2690), "This is a good recipe and it is the number 14", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2690), "Recipe nb°14", new Guid("81eca648-4396-4b46-aa47-fdf235d53f96") },
                    { new Guid("d1b00067-8e20-4d1a-8be5-8c11252a0e00"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2692), "This is a good recipe and it is the number 15", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2692), "Recipe nb°15", new Guid("59145dc4-1a25-4651-b2ec-9ce098fdc00b") },
                    { new Guid("d2803097-c580-40d7-8845-e5a744752bc9"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2667), "This is a good recipe and it is the number 2", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2667), "Recipe nb°2", new Guid("59145dc4-1a25-4651-b2ec-9ce098fdc00b") },
                    { new Guid("e0c3b086-5cb6-4425-ae1f-ec0537efe3ba"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2733), "This is a good recipe and it is the number 23", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2733), "Recipe nb°23", new Guid("1519cde9-bb2f-4794-a70d-2ccc51f69677") },
                    { new Guid("e0c6d50e-3cbc-49a9-9068-e8d173c78c50"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2670), "This is a good recipe and it is the number 4", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2671), "Recipe nb°4", new Guid("54780721-f126-41bc-9b56-d5835c2b1b8d") },
                    { new Guid("fc11f326-7c5d-4894-a47d-e54892bed991"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2693), "This is a good recipe and it is the number 16", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2693), "Recipe nb°16", new Guid("444d5ac7-2715-45a9-a7c5-ec6d17e37615") },
                    { new Guid("fedb1ed3-d736-4d29-8c63-0f94bc4309c8"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2724), "This is a good recipe and it is the number 19", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2724), "Recipe nb°19", new Guid("1519cde9-bb2f-4794-a70d-2ccc51f69677") }
                });

            migrationBuilder.InsertData(
                table: "PreparationStep",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name", "RecipeId", "Step", "StepNumber" },
                values: new object[,]
                {
                    { new Guid("086df844-501e-4289-8535-a292bb23508e"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2940), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2940), "Preparation step nb°37", new Guid("fedb1ed3-d736-4d29-8c63-0f94bc4309c8"), "Cook it", 1 },
                    { new Guid("0cf0aed3-dbea-4c5b-a59d-25dce6df1aba"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2911), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2912), "Preparation step nb°15", new Guid("6bd623bd-7740-43b9-a715-fdd8d3eafdba"), "Cook it", 1 },
                    { new Guid("0fc3a578-3bc6-43b8-abba-ada1dde79b7c"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2874), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2874), "Preparation step nb°5", new Guid("3a050935-9428-4529-bc1a-c77cd83807a3"), "Cook it", 1 },
                    { new Guid("21bc4c38-47f1-4ce1-b948-f6e00174c36e"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2870), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2870), "Preparation step nb°3", new Guid("d2803097-c580-40d7-8845-e5a744752bc9"), "Cook it", 1 },
                    { new Guid("24649aba-4477-4081-9af4-02531734bd92"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2879), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2879), "Preparation step nb°9", new Guid("1c32744a-4296-4812-a823-22679dafa728"), "Cook it", 1 },
                    { new Guid("289708ac-0614-42ad-ad45-2ea5ab7bc6ff"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2873), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2873), "Preparation step nb°4", new Guid("d2803097-c580-40d7-8845-e5a744752bc9"), "Cook it", 2 },
                    { new Guid("2c6f80a4-859e-414a-bee5-84c9fcadbaf3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2915), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2916), "Preparation step nb°18", new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16"), "Cook it", 2 },
                    { new Guid("4706ef77-79cb-4569-950f-05da431de850"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2943), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2944), "Preparation step nb°40", new Guid("31fef45d-618e-4215-a931-52a3970c06f5"), "Cook it", 2 },
                    { new Guid("4af5b171-095c-4854-bcbb-485ef3e7083e"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2951), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2951), "Preparation step nb°46", new Guid("e0c3b086-5cb6-4425-ae1f-ec0537efe3ba"), "Cook it", 2 },
                    { new Guid("527f758c-2102-4b6d-8538-d76088f947b9"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2953), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2953), "Preparation step nb°48", new Guid("6e6ce102-a213-40c2-81fe-7f8f2c7266f5"), "Cook it", 2 },
                    { new Guid("54182ba2-021f-4a9a-bfd6-8e4942c0a445"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2929), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2930), "Preparation step nb°28", new Guid("c32eeeb2-ed08-4547-bc5c-6f3a2f18e6e7"), "Cook it", 2 },
                    { new Guid("5af2e414-bde8-4e5b-88a0-3330f730da35"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2885), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2886), "Preparation step nb°13", new Guid("16dfbd83-e953-4abd-a489-741df71197c6"), "Cook it", 1 },
                    { new Guid("5dd87e7e-2f5d-4b64-a017-c39f7b910b38"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2931), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2932), "Preparation step nb°30", new Guid("d1b00067-8e20-4d1a-8be5-8c11252a0e00"), "Cook it", 2 },
                    { new Guid("627988a6-072a-42cd-9119-5c3a9b957142"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2910), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2910), "Preparation step nb°14", new Guid("16dfbd83-e953-4abd-a489-741df71197c6"), "Cook it", 2 },
                    { new Guid("64a7c011-001b-44c1-8f50-39f0cb5e315d"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2884), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2885), "Preparation step nb°12", new Guid("ba7f7595-ac84-4566-b16a-bfeebc07df3d"), "Cook it", 2 },
                    { new Guid("71e95059-97cd-42c3-adf2-02f1910bb880"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2950), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2950), "Preparation step nb°45", new Guid("e0c3b086-5cb6-4425-ae1f-ec0537efe3ba"), "Cook it", 1 },
                    { new Guid("72e3cf86-f387-4ae5-b617-4a076a9c9478"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2924), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2924), "Preparation step nb°24", new Guid("7e555f89-5dc0-4adc-a245-5a3254de1ccd"), "Cook it", 2 },
                    { new Guid("84811730-eade-44a7-86a6-1cde1e809b34"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2914), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2914), "Preparation step nb°17", new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16"), "Cook it", 1 },
                    { new Guid("89823df3-8acc-4171-a8ec-ea7153d22867"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2927), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2927), "Preparation step nb°27", new Guid("c32eeeb2-ed08-4547-bc5c-6f3a2f18e6e7"), "Cook it", 1 },
                    { new Guid("8bd85317-d762-4cfe-9143-4c5d608d0459"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2921), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2921), "Preparation step nb°21", new Guid("4e6362d5-bffc-4b93-976a-5b265deb1aa0"), "Cook it", 1 },
                    { new Guid("8e69e470-08a9-48c1-82ed-76ef069e605d"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2942), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2943), "Preparation step nb°39", new Guid("31fef45d-618e-4215-a931-52a3970c06f5"), "Cook it", 1 },
                    { new Guid("8f4003d7-d8e1-4dfb-a141-2a876535e18b"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2945), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2946), "Preparation step nb°42", new Guid("6c00e52f-d722-4a38-b6a2-488097c8a172"), "Cook it", 2 },
                    { new Guid("9acbbf6d-d89c-49fe-aaa1-644adbcfaa05"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2934), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2935), "Preparation step nb°33", new Guid("8bf17ef8-3866-4e85-942a-d572c71bffa3"), "Cook it", 1 },
                    { new Guid("a23e7c9b-33c4-4690-b2d1-990dd03f8b29"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2922), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2922), "Preparation step nb°22", new Guid("4e6362d5-bffc-4b93-976a-5b265deb1aa0"), "Cook it", 2 },
                    { new Guid("a333e4cc-6858-4dd7-8655-ffc2f6b76745"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2946), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2947), "Preparation step nb°43", new Guid("9e697c99-a30e-40e7-8a62-4d8e22c8d939"), "Cook it", 1 },
                    { new Guid("a7bb82a2-3df0-4789-af92-de07892d0b70"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2913), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2913), "Preparation step nb°16", new Guid("6bd623bd-7740-43b9-a715-fdd8d3eafdba"), "Cook it", 2 },
                    { new Guid("acf81e59-9086-4e30-b6bc-1b45c5bac323"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2876), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2876), "Preparation step nb°6", new Guid("3a050935-9428-4529-bc1a-c77cd83807a3"), "Cook it", 2 },
                    { new Guid("ae91c590-9b3e-4ee9-aab2-43714de7b997"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2868), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2869), "Preparation step nb°2", new Guid("984f0cd5-6ba6-4923-9e15-08ea713367c0"), "Cook it", 2 },
                    { new Guid("b17f3a26-15ae-4aa0-959c-c02250546d7a"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2933), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2934), "Preparation step nb°32", new Guid("fc11f326-7c5d-4894-a47d-e54892bed991"), "Cook it", 2 },
                    { new Guid("beb226b2-810e-40a7-96db-c0c0cc47155f"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2949), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2949), "Preparation step nb°44", new Guid("9e697c99-a30e-40e7-8a62-4d8e22c8d939"), "Cook it", 2 },
                    { new Guid("c29210e6-bb7e-436e-b2df-2242fa7ded36"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2881), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2881), "Preparation step nb°10", new Guid("1c32744a-4296-4812-a823-22679dafa728"), "Cook it", 2 },
                    { new Guid("c48685fc-1df2-4075-8431-f59a932f2fe1"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2920), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2920), "Preparation step nb°20", new Guid("4d1f0d33-05a4-4bc6-83e2-5716a4e34d46"), "Cook it", 2 },
                    { new Guid("c6ad2392-a816-4604-b678-bea9475a8ac2"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2863), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2863), "Preparation step nb°1", new Guid("984f0cd5-6ba6-4923-9e15-08ea713367c0"), "Cook it", 1 },
                    { new Guid("cc453c9c-de06-4a25-987e-b24efaecc8a8"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2944), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2945), "Preparation step nb°41", new Guid("6c00e52f-d722-4a38-b6a2-488097c8a172"), "Cook it", 1 },
                    { new Guid("ce3cf007-e6f3-4e65-878d-a8306b6d0080"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2878), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2878), "Preparation step nb°8", new Guid("e0c6d50e-3cbc-49a9-9068-e8d173c78c50"), "Cook it", 2 },
                    { new Guid("d56ef690-d3bb-417c-a112-e2496685897c"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2954), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2954), "Preparation step nb°49", new Guid("be9c6afc-5bb0-4733-be3e-3762e2b62232"), "Cook it", 1 },
                    { new Guid("d59b5da2-9e70-4845-9cd7-b84367ff41a4"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2877), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2877), "Preparation step nb°7", new Guid("e0c6d50e-3cbc-49a9-9068-e8d173c78c50"), "Cook it", 1 },
                    { new Guid("d8d8953b-87ed-4a82-87e1-e1c9f8a38196"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2939), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2939), "Preparation step nb°36", new Guid("27f4bdc6-96d5-4e52-be8b-ae5e2f531621"), "Cook it", 2 },
                    { new Guid("dacaf235-cc4e-45b5-8d75-3464232fc8c9"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2882), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2882), "Preparation step nb°11", new Guid("ba7f7595-ac84-4566-b16a-bfeebc07df3d"), "Cook it", 1 },
                    { new Guid("dd67bfde-c953-47fd-b266-5a2a607c2828"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2917), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2917), "Preparation step nb°19", new Guid("4d1f0d33-05a4-4bc6-83e2-5716a4e34d46"), "Cook it", 1 },
                    { new Guid("df1a347d-6b93-45c5-ab3e-4132afb865d3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2941), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2941), "Preparation step nb°38", new Guid("fedb1ed3-d736-4d29-8c63-0f94bc4309c8"), "Cook it", 2 },
                    { new Guid("e074e063-a442-405c-b638-5eb3a6669d5f"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2926), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2926), "Preparation step nb°26", new Guid("2bbe1f1b-8011-438f-887b-9d0dcb4f5b16"), "Cook it", 2 },
                    { new Guid("e238c37f-047b-4a0e-a4ad-bee825736879"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2925), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2925), "Preparation step nb°25", new Guid("2bbe1f1b-8011-438f-887b-9d0dcb4f5b16"), "Cook it", 1 },
                    { new Guid("e7587812-2b31-4625-8c59-3c34a60555b2"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2932), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2933), "Preparation step nb°31", new Guid("fc11f326-7c5d-4894-a47d-e54892bed991"), "Cook it", 1 },
                    { new Guid("ef8cd3f3-8469-403b-84de-ba567b2c94ec"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2952), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2952), "Preparation step nb°47", new Guid("6e6ce102-a213-40c2-81fe-7f8f2c7266f5"), "Cook it", 1 },
                    { new Guid("f3ef24c3-c887-4b60-8d28-b78b6cdce51e"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2930), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2931), "Preparation step nb°29", new Guid("d1b00067-8e20-4d1a-8be5-8c11252a0e00"), "Cook it", 1 },
                    { new Guid("f4944043-4ff9-4bc5-bae5-f0c0ba444a2d"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2955), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2955), "Preparation step nb°50", new Guid("be9c6afc-5bb0-4733-be3e-3762e2b62232"), "Cook it", 2 },
                    { new Guid("f8a5718c-ff87-4a38-ba1e-fb46a186a44f"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2937), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2937), "Preparation step nb°35", new Guid("27f4bdc6-96d5-4e52-be8b-ae5e2f531621"), "Cook it", 1 },
                    { new Guid("f9b092b7-6560-4329-8829-54248688e626"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2923), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2923), "Preparation step nb°23", new Guid("7e555f89-5dc0-4adc-a245-5a3254de1ccd"), "Cook it", 1 },
                    { new Guid("fd1715e5-8d30-4dbc-8ad1-d8f41380fca0"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2936), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2936), "Preparation step nb°34", new Guid("8bf17ef8-3866-4e85-942a-d572c71bffa3"), "Cook it", 2 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredient",
                columns: new[] { "IngredientId", "RecipeId", "CreatedOn", "IngredientQuantity", "ModifiedOn" },
                values: new object[,]
                {
                    { new Guid("0081bc3f-d0ee-4cd7-8d24-ded5a44d3d9a"), new Guid("ba7f7595-ac84-4566-b16a-bfeebc07df3d"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2793), "268 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2793) },
                    { new Guid("05716eea-e8a7-4830-9646-f3cf97357301"), new Guid("31fef45d-618e-4215-a931-52a3970c06f5"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2829), "130 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2829) },
                    { new Guid("0b9f4368-3096-40a7-aaf4-032d79f1625f"), new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2804), "253 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2804) },
                    { new Guid("0db6c695-371c-4913-9312-8186ad3a6b2b"), new Guid("c32eeeb2-ed08-4547-bc5c-6f3a2f18e6e7"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2836), "263 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2837) },
                    { new Guid("12becc48-269b-4c81-970b-ddd2f7bdfce3"), new Guid("6e6ce102-a213-40c2-81fe-7f8f2c7266f5"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2788), "131 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2788) },
                    { new Guid("13881b4e-a800-4fac-bce4-1ffb9c067fc3"), new Guid("27f4bdc6-96d5-4e52-be8b-ae5e2f531621"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2841), "378 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2841) },
                    { new Guid("1f8d0a6d-23e6-4a21-9409-2ae72c9ac48f"), new Guid("8bf17ef8-3866-4e85-942a-d572c71bffa3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2843), "433 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2843) },
                    { new Guid("255884f5-b685-4272-87dd-e7df4891d8bb"), new Guid("c32eeeb2-ed08-4547-bc5c-6f3a2f18e6e7"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2832), "407 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2832) },
                    { new Guid("3239b4bf-cd50-4d89-9a54-c5b9d86bdbf5"), new Guid("6e6ce102-a213-40c2-81fe-7f8f2c7266f5"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2778), "484 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2778) },
                    { new Guid("32f5786f-a6f0-4246-8c87-872bda815a04"), new Guid("d2803097-c580-40d7-8845-e5a744752bc9"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2831), "212 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2831) },
                    { new Guid("372309da-d077-45fd-968a-c12cd88d6077"), new Guid("31fef45d-618e-4215-a931-52a3970c06f5"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2780), "299 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2780) },
                    { new Guid("375587bb-34c1-41da-9c5b-a7116b1b0299"), new Guid("3a050935-9428-4529-bc1a-c77cd83807a3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2791), "280 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2791) },
                    { new Guid("38552395-f22f-42db-b550-7a90630034fb"), new Guid("e0c6d50e-3cbc-49a9-9068-e8d173c78c50"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2783), "287 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2783) },
                    { new Guid("38ca97dd-0c37-4994-812e-dc5411b65303"), new Guid("6bd623bd-7740-43b9-a715-fdd8d3eafdba"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2784), "328 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2784) },
                    { new Guid("44c7bc6f-5957-4217-9145-3eff5a6d4512"), new Guid("4d1f0d33-05a4-4bc6-83e2-5716a4e34d46"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2837), "307 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2837) },
                    { new Guid("46d0c984-705e-45c9-a71f-6c4c80856930"), new Guid("3a050935-9428-4529-bc1a-c77cd83807a3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2835), "192 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2835) },
                    { new Guid("549b224c-5977-4bbc-b9f3-f365b69f6931"), new Guid("e0c3b086-5cb6-4425-ae1f-ec0537efe3ba"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2827), "197 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2827) },
                    { new Guid("5aa6ee85-1fde-4b0f-9595-1d9104336468"), new Guid("6bd623bd-7740-43b9-a715-fdd8d3eafdba"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2850), "223 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2850) },
                    { new Guid("5afa2a01-831b-427c-b7e8-1ac415925f7d"), new Guid("c32eeeb2-ed08-4547-bc5c-6f3a2f18e6e7"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2790), "434 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2790) },
                    { new Guid("5c186316-8f25-4d97-a83e-fd10fe6c668f"), new Guid("3a050935-9428-4529-bc1a-c77cd83807a3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2802), "182 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2802) },
                    { new Guid("5fa70ef5-cb56-4d23-a789-04cc243ed861"), new Guid("4d1f0d33-05a4-4bc6-83e2-5716a4e34d46"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2845), "144 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2845) },
                    { new Guid("69d96265-2d9a-495f-93bd-232242e98669"), new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2846), "106 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2846) },
                    { new Guid("6b28816a-8818-472e-93fc-6f0ffc0fbf65"), new Guid("27f4bdc6-96d5-4e52-be8b-ae5e2f531621"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2782), "479 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2782) },
                    { new Guid("6c4e74ba-4a1f-44ed-b48b-3b8ed5139213"), new Guid("3a050935-9428-4529-bc1a-c77cd83807a3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2766), "224 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2767) },
                    { new Guid("6cd57ab9-87c9-4ec6-85f0-2c28d9a9a34d"), new Guid("3a050935-9428-4529-bc1a-c77cd83807a3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2847), "386 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2847) },
                    { new Guid("6ffa1f53-3b5e-48cb-93ec-e6d467a9e5f0"), new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2797), "228 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2797) },
                    { new Guid("71d2b2f2-ce0e-4b9b-a5ac-bab2742173b2"), new Guid("4e6362d5-bffc-4b93-976a-5b265deb1aa0"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2828), "317 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2828) },
                    { new Guid("787e9016-4122-461e-8c04-695a057eb194"), new Guid("ba7f7595-ac84-4566-b16a-bfeebc07df3d"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2799), "362 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2799) },
                    { new Guid("7c2f69bc-175f-4f88-a6ea-736f799023a1"), new Guid("be9c6afc-5bb0-4733-be3e-3762e2b62232"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2842), "155 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2842) },
                    { new Guid("81fd9455-4599-482d-8ca0-96a2a8e90e44"), new Guid("31fef45d-618e-4215-a931-52a3970c06f5"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2798), "264 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2798) },
                    { new Guid("8b5a4d1c-f8ee-4c22-9bdc-176dad05ddcb"), new Guid("ba7f7595-ac84-4566-b16a-bfeebc07df3d"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2844), "468 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2844) },
                    { new Guid("91e38179-5d5e-4fc1-9cb7-9482d775cdd4"), new Guid("e0c3b086-5cb6-4425-ae1f-ec0537efe3ba"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2839), "317 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2840) },
                    { new Guid("93855115-cc33-4755-b8ec-0bd1aaa783d2"), new Guid("e0c3b086-5cb6-4425-ae1f-ec0537efe3ba"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2838), "274 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2838) },
                    { new Guid("94ff1b26-33a5-4d29-aad4-1846538c37c9"), new Guid("984f0cd5-6ba6-4923-9e15-08ea713367c0"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2840), "467 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2840) },
                    { new Guid("99efa985-85ac-4b3c-a55f-7498ae862aa4"), new Guid("be9c6afc-5bb0-4733-be3e-3762e2b62232"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2801), "414 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2801) },
                    { new Guid("a82fe951-8233-4a1a-b0ee-518e78f286ba"), new Guid("1c32744a-4296-4812-a823-22679dafa728"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2792), "311 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2792) },
                    { new Guid("ad2d9a85-f6b4-43eb-9715-7801b0f95c4f"), new Guid("9e697c99-a30e-40e7-8a62-4d8e22c8d939"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2800), "195 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2800) },
                    { new Guid("b84169d2-8e9b-4902-99e6-bccc1f39a840"), new Guid("16dfbd83-e953-4abd-a489-741df71197c6"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2794), "478 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2794) },
                    { new Guid("badbfd2c-b715-4162-9d22-fac0ed14e18b"), new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2848), "314 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2848) },
                    { new Guid("bb572009-700e-4afa-9108-44f49840c0e0"), new Guid("3a050935-9428-4529-bc1a-c77cd83807a3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2833), "136 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2833) },
                    { new Guid("bfc3e3d4-8282-44e9-b190-2c828e451b9e"), new Guid("c32eeeb2-ed08-4547-bc5c-6f3a2f18e6e7"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2849), "117 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2849) },
                    { new Guid("c54800ec-5e30-404c-8a4d-8a1d6a300dea"), new Guid("d2803097-c580-40d7-8845-e5a744752bc9"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2836), "359 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2836) },
                    { new Guid("ce67cbcd-2979-41ba-95d6-19beec2a862d"), new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2796), "433 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2796) },
                    { new Guid("d22c0e5a-cfcb-4683-bee9-e6d9041e8b54"), new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2773), "398 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2774) },
                    { new Guid("dbfbfae8-0bea-4622-886e-5257149028b5"), new Guid("fc11f326-7c5d-4894-a47d-e54892bed991"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2775), "237 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2775) },
                    { new Guid("dd2c968e-f97d-41af-82d9-f885f885bba6"), new Guid("e0c6d50e-3cbc-49a9-9068-e8d173c78c50"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2757), "369 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2757) },
                    { new Guid("e366a63d-c230-4182-93d6-747de780f33a"), new Guid("8bf17ef8-3866-4e85-942a-d572c71bffa3"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2787), "367 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2787) },
                    { new Guid("ec31fa8a-3c8c-4447-a45d-b9b002e5f3ae"), new Guid("d1b00067-8e20-4d1a-8be5-8c11252a0e00"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2795), "356 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2795) },
                    { new Guid("ee4abc1e-5b56-4549-97d2-6938d5e2b093"), new Guid("984f0cd5-6ba6-4923-9e15-08ea713367c0"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2830), "348 g", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2830) },
                    { new Guid("f1c9af2f-06a7-42c7-ba8f-fd32d438e512"), new Guid("16dfbd83-e953-4abd-a489-741df71197c6"), new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2785), "115 ml", new DateTime(2024, 5, 1, 12, 2, 26, 544, DateTimeKind.Utc).AddTicks(2786) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("086df844-501e-4289-8535-a292bb23508e"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("0cf0aed3-dbea-4c5b-a59d-25dce6df1aba"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("0fc3a578-3bc6-43b8-abba-ada1dde79b7c"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("21bc4c38-47f1-4ce1-b948-f6e00174c36e"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("24649aba-4477-4081-9af4-02531734bd92"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("289708ac-0614-42ad-ad45-2ea5ab7bc6ff"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("2c6f80a4-859e-414a-bee5-84c9fcadbaf3"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("4706ef77-79cb-4569-950f-05da431de850"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("4af5b171-095c-4854-bcbb-485ef3e7083e"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("527f758c-2102-4b6d-8538-d76088f947b9"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("54182ba2-021f-4a9a-bfd6-8e4942c0a445"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("5af2e414-bde8-4e5b-88a0-3330f730da35"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("5dd87e7e-2f5d-4b64-a017-c39f7b910b38"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("627988a6-072a-42cd-9119-5c3a9b957142"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("64a7c011-001b-44c1-8f50-39f0cb5e315d"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("71e95059-97cd-42c3-adf2-02f1910bb880"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("72e3cf86-f387-4ae5-b617-4a076a9c9478"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("84811730-eade-44a7-86a6-1cde1e809b34"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("89823df3-8acc-4171-a8ec-ea7153d22867"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("8bd85317-d762-4cfe-9143-4c5d608d0459"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("8e69e470-08a9-48c1-82ed-76ef069e605d"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("8f4003d7-d8e1-4dfb-a141-2a876535e18b"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("9acbbf6d-d89c-49fe-aaa1-644adbcfaa05"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a23e7c9b-33c4-4690-b2d1-990dd03f8b29"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a333e4cc-6858-4dd7-8655-ffc2f6b76745"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a7bb82a2-3df0-4789-af92-de07892d0b70"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("acf81e59-9086-4e30-b6bc-1b45c5bac323"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("ae91c590-9b3e-4ee9-aab2-43714de7b997"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("b17f3a26-15ae-4aa0-959c-c02250546d7a"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("beb226b2-810e-40a7-96db-c0c0cc47155f"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("c29210e6-bb7e-436e-b2df-2242fa7ded36"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("c48685fc-1df2-4075-8431-f59a932f2fe1"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("c6ad2392-a816-4604-b678-bea9475a8ac2"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("cc453c9c-de06-4a25-987e-b24efaecc8a8"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("ce3cf007-e6f3-4e65-878d-a8306b6d0080"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("d56ef690-d3bb-417c-a112-e2496685897c"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("d59b5da2-9e70-4845-9cd7-b84367ff41a4"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("d8d8953b-87ed-4a82-87e1-e1c9f8a38196"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("dacaf235-cc4e-45b5-8d75-3464232fc8c9"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("dd67bfde-c953-47fd-b266-5a2a607c2828"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("df1a347d-6b93-45c5-ab3e-4132afb865d3"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("e074e063-a442-405c-b638-5eb3a6669d5f"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("e238c37f-047b-4a0e-a4ad-bee825736879"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("e7587812-2b31-4625-8c59-3c34a60555b2"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("ef8cd3f3-8469-403b-84de-ba567b2c94ec"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("f3ef24c3-c887-4b60-8d28-b78b6cdce51e"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("f4944043-4ff9-4bc5-bae5-f0c0ba444a2d"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("f8a5718c-ff87-4a38-ba1e-fb46a186a44f"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("f9b092b7-6560-4329-8829-54248688e626"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("fd1715e5-8d30-4dbc-8ad1-d8f41380fca0"));

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("0081bc3f-d0ee-4cd7-8d24-ded5a44d3d9a"), new Guid("ba7f7595-ac84-4566-b16a-bfeebc07df3d") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("05716eea-e8a7-4830-9646-f3cf97357301"), new Guid("31fef45d-618e-4215-a931-52a3970c06f5") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("0b9f4368-3096-40a7-aaf4-032d79f1625f"), new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("0db6c695-371c-4913-9312-8186ad3a6b2b"), new Guid("c32eeeb2-ed08-4547-bc5c-6f3a2f18e6e7") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("12becc48-269b-4c81-970b-ddd2f7bdfce3"), new Guid("6e6ce102-a213-40c2-81fe-7f8f2c7266f5") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("13881b4e-a800-4fac-bce4-1ffb9c067fc3"), new Guid("27f4bdc6-96d5-4e52-be8b-ae5e2f531621") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("1f8d0a6d-23e6-4a21-9409-2ae72c9ac48f"), new Guid("8bf17ef8-3866-4e85-942a-d572c71bffa3") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("255884f5-b685-4272-87dd-e7df4891d8bb"), new Guid("c32eeeb2-ed08-4547-bc5c-6f3a2f18e6e7") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("3239b4bf-cd50-4d89-9a54-c5b9d86bdbf5"), new Guid("6e6ce102-a213-40c2-81fe-7f8f2c7266f5") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("32f5786f-a6f0-4246-8c87-872bda815a04"), new Guid("d2803097-c580-40d7-8845-e5a744752bc9") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("372309da-d077-45fd-968a-c12cd88d6077"), new Guid("31fef45d-618e-4215-a931-52a3970c06f5") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("375587bb-34c1-41da-9c5b-a7116b1b0299"), new Guid("3a050935-9428-4529-bc1a-c77cd83807a3") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("38552395-f22f-42db-b550-7a90630034fb"), new Guid("e0c6d50e-3cbc-49a9-9068-e8d173c78c50") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("38ca97dd-0c37-4994-812e-dc5411b65303"), new Guid("6bd623bd-7740-43b9-a715-fdd8d3eafdba") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("44c7bc6f-5957-4217-9145-3eff5a6d4512"), new Guid("4d1f0d33-05a4-4bc6-83e2-5716a4e34d46") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("46d0c984-705e-45c9-a71f-6c4c80856930"), new Guid("3a050935-9428-4529-bc1a-c77cd83807a3") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("549b224c-5977-4bbc-b9f3-f365b69f6931"), new Guid("e0c3b086-5cb6-4425-ae1f-ec0537efe3ba") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("5aa6ee85-1fde-4b0f-9595-1d9104336468"), new Guid("6bd623bd-7740-43b9-a715-fdd8d3eafdba") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("5afa2a01-831b-427c-b7e8-1ac415925f7d"), new Guid("c32eeeb2-ed08-4547-bc5c-6f3a2f18e6e7") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("5c186316-8f25-4d97-a83e-fd10fe6c668f"), new Guid("3a050935-9428-4529-bc1a-c77cd83807a3") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("5fa70ef5-cb56-4d23-a789-04cc243ed861"), new Guid("4d1f0d33-05a4-4bc6-83e2-5716a4e34d46") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("69d96265-2d9a-495f-93bd-232242e98669"), new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("6b28816a-8818-472e-93fc-6f0ffc0fbf65"), new Guid("27f4bdc6-96d5-4e52-be8b-ae5e2f531621") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("6c4e74ba-4a1f-44ed-b48b-3b8ed5139213"), new Guid("3a050935-9428-4529-bc1a-c77cd83807a3") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("6cd57ab9-87c9-4ec6-85f0-2c28d9a9a34d"), new Guid("3a050935-9428-4529-bc1a-c77cd83807a3") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("6ffa1f53-3b5e-48cb-93ec-e6d467a9e5f0"), new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("71d2b2f2-ce0e-4b9b-a5ac-bab2742173b2"), new Guid("4e6362d5-bffc-4b93-976a-5b265deb1aa0") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("787e9016-4122-461e-8c04-695a057eb194"), new Guid("ba7f7595-ac84-4566-b16a-bfeebc07df3d") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("7c2f69bc-175f-4f88-a6ea-736f799023a1"), new Guid("be9c6afc-5bb0-4733-be3e-3762e2b62232") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("81fd9455-4599-482d-8ca0-96a2a8e90e44"), new Guid("31fef45d-618e-4215-a931-52a3970c06f5") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("8b5a4d1c-f8ee-4c22-9bdc-176dad05ddcb"), new Guid("ba7f7595-ac84-4566-b16a-bfeebc07df3d") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("91e38179-5d5e-4fc1-9cb7-9482d775cdd4"), new Guid("e0c3b086-5cb6-4425-ae1f-ec0537efe3ba") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("93855115-cc33-4755-b8ec-0bd1aaa783d2"), new Guid("e0c3b086-5cb6-4425-ae1f-ec0537efe3ba") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("94ff1b26-33a5-4d29-aad4-1846538c37c9"), new Guid("984f0cd5-6ba6-4923-9e15-08ea713367c0") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("99efa985-85ac-4b3c-a55f-7498ae862aa4"), new Guid("be9c6afc-5bb0-4733-be3e-3762e2b62232") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("a82fe951-8233-4a1a-b0ee-518e78f286ba"), new Guid("1c32744a-4296-4812-a823-22679dafa728") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("ad2d9a85-f6b4-43eb-9715-7801b0f95c4f"), new Guid("9e697c99-a30e-40e7-8a62-4d8e22c8d939") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("b84169d2-8e9b-4902-99e6-bccc1f39a840"), new Guid("16dfbd83-e953-4abd-a489-741df71197c6") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("badbfd2c-b715-4162-9d22-fac0ed14e18b"), new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("bb572009-700e-4afa-9108-44f49840c0e0"), new Guid("3a050935-9428-4529-bc1a-c77cd83807a3") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("bfc3e3d4-8282-44e9-b190-2c828e451b9e"), new Guid("c32eeeb2-ed08-4547-bc5c-6f3a2f18e6e7") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("c54800ec-5e30-404c-8a4d-8a1d6a300dea"), new Guid("d2803097-c580-40d7-8845-e5a744752bc9") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("ce67cbcd-2979-41ba-95d6-19beec2a862d"), new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("d22c0e5a-cfcb-4683-bee9-e6d9041e8b54"), new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("dbfbfae8-0bea-4622-886e-5257149028b5"), new Guid("fc11f326-7c5d-4894-a47d-e54892bed991") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("dd2c968e-f97d-41af-82d9-f885f885bba6"), new Guid("e0c6d50e-3cbc-49a9-9068-e8d173c78c50") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("e366a63d-c230-4182-93d6-747de780f33a"), new Guid("8bf17ef8-3866-4e85-942a-d572c71bffa3") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("ec31fa8a-3c8c-4447-a45d-b9b002e5f3ae"), new Guid("d1b00067-8e20-4d1a-8be5-8c11252a0e00") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("ee4abc1e-5b56-4549-97d2-6938d5e2b093"), new Guid("984f0cd5-6ba6-4923-9e15-08ea713367c0") });

            migrationBuilder.DeleteData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("f1c9af2f-06a7-42c7-ba8f-fd32d438e512"), new Guid("16dfbd83-e953-4abd-a489-741df71197c6") });

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("0081bc3f-d0ee-4cd7-8d24-ded5a44d3d9a"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("05716eea-e8a7-4830-9646-f3cf97357301"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("0b9f4368-3096-40a7-aaf4-032d79f1625f"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("0db6c695-371c-4913-9312-8186ad3a6b2b"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("12becc48-269b-4c81-970b-ddd2f7bdfce3"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("13881b4e-a800-4fac-bce4-1ffb9c067fc3"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("1f8d0a6d-23e6-4a21-9409-2ae72c9ac48f"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("255884f5-b685-4272-87dd-e7df4891d8bb"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("3239b4bf-cd50-4d89-9a54-c5b9d86bdbf5"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("32f5786f-a6f0-4246-8c87-872bda815a04"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("372309da-d077-45fd-968a-c12cd88d6077"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("375587bb-34c1-41da-9c5b-a7116b1b0299"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("38552395-f22f-42db-b550-7a90630034fb"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("38ca97dd-0c37-4994-812e-dc5411b65303"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("44c7bc6f-5957-4217-9145-3eff5a6d4512"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("46d0c984-705e-45c9-a71f-6c4c80856930"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("549b224c-5977-4bbc-b9f3-f365b69f6931"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5aa6ee85-1fde-4b0f-9595-1d9104336468"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5afa2a01-831b-427c-b7e8-1ac415925f7d"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5c186316-8f25-4d97-a83e-fd10fe6c668f"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("5fa70ef5-cb56-4d23-a789-04cc243ed861"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("69d96265-2d9a-495f-93bd-232242e98669"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("6b28816a-8818-472e-93fc-6f0ffc0fbf65"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("6c4e74ba-4a1f-44ed-b48b-3b8ed5139213"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("6cd57ab9-87c9-4ec6-85f0-2c28d9a9a34d"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("6ffa1f53-3b5e-48cb-93ec-e6d467a9e5f0"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("71d2b2f2-ce0e-4b9b-a5ac-bab2742173b2"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("787e9016-4122-461e-8c04-695a057eb194"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("7c2f69bc-175f-4f88-a6ea-736f799023a1"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("81fd9455-4599-482d-8ca0-96a2a8e90e44"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("8b5a4d1c-f8ee-4c22-9bdc-176dad05ddcb"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("91e38179-5d5e-4fc1-9cb7-9482d775cdd4"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("93855115-cc33-4755-b8ec-0bd1aaa783d2"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("94ff1b26-33a5-4d29-aad4-1846538c37c9"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("99efa985-85ac-4b3c-a55f-7498ae862aa4"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("a82fe951-8233-4a1a-b0ee-518e78f286ba"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("ad2d9a85-f6b4-43eb-9715-7801b0f95c4f"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("b84169d2-8e9b-4902-99e6-bccc1f39a840"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("badbfd2c-b715-4162-9d22-fac0ed14e18b"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("bb572009-700e-4afa-9108-44f49840c0e0"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("bfc3e3d4-8282-44e9-b190-2c828e451b9e"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("c54800ec-5e30-404c-8a4d-8a1d6a300dea"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("ce67cbcd-2979-41ba-95d6-19beec2a862d"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("d22c0e5a-cfcb-4683-bee9-e6d9041e8b54"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("dbfbfae8-0bea-4622-886e-5257149028b5"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("dd2c968e-f97d-41af-82d9-f885f885bba6"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("e366a63d-c230-4182-93d6-747de780f33a"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("ec31fa8a-3c8c-4447-a45d-b9b002e5f3ae"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("ee4abc1e-5b56-4549-97d2-6938d5e2b093"));

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("f1c9af2f-06a7-42c7-ba8f-fd32d438e512"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("16dfbd83-e953-4abd-a489-741df71197c6"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("1c32744a-4296-4812-a823-22679dafa728"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("27f4bdc6-96d5-4e52-be8b-ae5e2f531621"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("2bbe1f1b-8011-438f-887b-9d0dcb4f5b16"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("31fef45d-618e-4215-a931-52a3970c06f5"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("3a050935-9428-4529-bc1a-c77cd83807a3"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("4d1f0d33-05a4-4bc6-83e2-5716a4e34d46"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("4e6362d5-bffc-4b93-976a-5b265deb1aa0"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("6bd623bd-7740-43b9-a715-fdd8d3eafdba"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("6c00e52f-d722-4a38-b6a2-488097c8a172"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("6e6ce102-a213-40c2-81fe-7f8f2c7266f5"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("7e555f89-5dc0-4adc-a245-5a3254de1ccd"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("8bf17ef8-3866-4e85-942a-d572c71bffa3"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("984f0cd5-6ba6-4923-9e15-08ea713367c0"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("9da600b2-a9b2-48c0-8781-fcaea34bfe16"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("9e697c99-a30e-40e7-8a62-4d8e22c8d939"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("ba7f7595-ac84-4566-b16a-bfeebc07df3d"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("be9c6afc-5bb0-4733-be3e-3762e2b62232"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("c32eeeb2-ed08-4547-bc5c-6f3a2f18e6e7"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("d1b00067-8e20-4d1a-8be5-8c11252a0e00"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("d2803097-c580-40d7-8845-e5a744752bc9"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("e0c3b086-5cb6-4425-ae1f-ec0537efe3ba"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("e0c6d50e-3cbc-49a9-9068-e8d173c78c50"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("fc11f326-7c5d-4894-a47d-e54892bed991"));

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("fedb1ed3-d736-4d29-8c63-0f94bc4309c8"));

            migrationBuilder.DeleteData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("1519cde9-bb2f-4794-a70d-2ccc51f69677"));

            migrationBuilder.DeleteData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("444d5ac7-2715-45a9-a7c5-ec6d17e37615"));

            migrationBuilder.DeleteData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("4d287bbb-b688-4d11-82dd-0d75b1108cdc"));

            migrationBuilder.DeleteData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("50a35183-8609-437d-8ffd-8498efd66540"));

            migrationBuilder.DeleteData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("54780721-f126-41bc-9b56-d5835c2b1b8d"));

            migrationBuilder.DeleteData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("59145dc4-1a25-4651-b2ec-9ce098fdc00b"));

            migrationBuilder.DeleteData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("81eca648-4396-4b46-aa47-fdf235d53f96"));

            migrationBuilder.DeleteData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("c5102b51-bf2a-47e5-aee2-43f6409f8d21"));

            migrationBuilder.DeleteData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("c6543897-f556-4cba-b0cb-703baf76d8fc"));

            migrationBuilder.DeleteData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("dfb15546-4117-4c55-b983-30a5d67acd3a"));
        }
    }
}
