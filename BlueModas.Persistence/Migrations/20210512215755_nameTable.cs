using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueModas.Persistence.Migrations
{
    public partial class nameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemMapping_Order_OrderId",
                table: "OrderItemMapping");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemMapping_Product_ProductId",
                table: "OrderItemMapping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItemMapping",
                table: "OrderItemMapping");

            migrationBuilder.RenameTable(
                name: "OrderItemMapping",
                newName: "OrderItem");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItemMapping_ProductId",
                table: "OrderItem",
                newName: "IX_OrderItem_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItemMapping_OrderId",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Product_ProductId",
                table: "OrderItem",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Product_ProductId",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem");

            migrationBuilder.RenameTable(
                name: "OrderItem",
                newName: "OrderItemMapping");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItemMapping",
                newName: "IX_OrderItemMapping_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItemMapping",
                newName: "IX_OrderItemMapping_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItemMapping",
                table: "OrderItemMapping",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemMapping_Order_OrderId",
                table: "OrderItemMapping",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemMapping_Product_ProductId",
                table: "OrderItemMapping",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
