using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PizzaBox.Storage.Migrations
{
    public partial class orderandpizzadbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CrustEntityId = table.Column<long>(type: "bigint", nullable: false),
                    SizeEntityId = table.Column<long>(type: "bigint", nullable: false),
                    OrderEntityId = table.Column<long>(type: "bigint", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Pizzas_Crusts_CrustEntityId",
                        column: x => x.CrustEntityId,
                        principalTable: "Crusts",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pizzas_Orders_OrderEntityId",
                        column: x => x.OrderEntityId,
                        principalTable: "Orders",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pizzas_Sizes_SizeEntityId",
                        column: x => x.SizeEntityId,
                        principalTable: "Sizes",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "APizzaTopping",
                columns: table => new
                {
                    PizzasEntityId = table.Column<long>(type: "bigint", nullable: false),
                    ToppingsEntityId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APizzaTopping", x => new { x.PizzasEntityId, x.ToppingsEntityId });
                    table.ForeignKey(
                        name: "FK_APizzaTopping_Pizzas_PizzasEntityId",
                        column: x => x.PizzasEntityId,
                        principalTable: "Pizzas",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_APizzaTopping_Toppings_ToppingsEntityId",
                        column: x => x.ToppingsEntityId,
                        principalTable: "Toppings",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Name",
                value: "Original");

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Name",
                value: "Thin");

            migrationBuilder.InsertData(
                table: "Crusts",
                columns: new[] { "EntityId", "Name", "Price" },
                values: new object[] { 3L, "Stuffed", 7m });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 4L,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Ham", 3m });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 5L,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Sausage", 3m });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "EntityId", "Name", "Price" },
                values: new object[,]
                {
                    { 6L, "Black Olives", 1m },
                    { 7L, "Green Peppers", 1m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_APizzaTopping_ToppingsEntityId",
                table: "APizzaTopping",
                column: "ToppingsEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustEntityId",
                table: "Pizzas",
                column: "CrustEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_OrderEntityId",
                table: "Pizzas",
                column: "OrderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeEntityId",
                table: "Pizzas",
                column: "SizeEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APizzaTopping");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 7L);

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Name",
                value: "original");

            migrationBuilder.UpdateData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Name",
                value: "thin");

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 4L,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Black Olives", 1m });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 5L,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Green Peppers", 1m });
        }
    }
}
