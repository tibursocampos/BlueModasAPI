using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueModas.Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Email", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "raphael@teste.com", "Raphael", "123456", "(35) 98811-1492" },
                    { 2, "aantonellasarahcristianearaujo@yahool.com", "Antonella Sarah Cristiane Araújo", "123456", "(12) 99982-6766" },
                    { 3, "cesarmurilomoreira..cesarmurilomoreira@ornatopresentes.com.br", "César Murilo Moreira", "123456", "(82) 98635-7667" },
                    { 4, "emanuellyclaudiadias..emanuellyclaudiadias@osbocops.com", "Emanuelly Cláudia Dias", "123456", "(27) 98498-9488" },
                    { 5, "iandavidanielfarias__iandavidanielfarias@silnave.com.br", "Ian Davi Daniel Farias", "123456", "(21) 98907-0282" },
                    { 6, "camilateresinhadamata-72@bds.com.br", "Camila Teresinha da Mata", "123456", "(89) 98901-1497" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Amount", "Category", "Description", "Gender", "Image", "Name", "Price", "Size" },
                values: new object[,]
                {
                    { 1, 100, 1, "Camiseta casual com tecido leve", 1, null, "Camiseta Preta", 20.5, 3 },
                    { 2, 100, 1, "Camiseta casual com tecido leve", 2, null, "Camiseta Preta", 25.0, 2 },
                    { 3, 100, 1, "Camiseta casual com tecido leve", 1, null, "Camiseta Vermelha", 30.0, 3 },
                    { 4, 100, 1, "Camiseta casual com tecido leve", 2, null, "Camiseta Rosa", 30.0, 1 },
                    { 5, 100, 2, "Camisa social de algodão", 1, null, "Camisa Preta", 60.0, 4 },
                    { 6, 100, 2, "Camisa social de algodão", 1, null, "Camisa Preta", 60.0, 3 },
                    { 7, 100, 3, "Calça jeans", 2, null, "Calça Branca", 110.5, 2 },
                    { 8, 100, 3, "Calça jeans", 1, null, "Calça Preta", 110.5, 3 },
                    { 9, 100, 4, "Bermuda jeans", 2, null, "Bermuda Azul", 40.0, 3 },
                    { 10, 100, 4, "Bermuda tactel", 1, null, "Bermuda Preta", 30.0, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientId",
                table: "Order",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
