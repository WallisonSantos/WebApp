using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Service.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PRODUCT",
                columns: new[] { "PRODUCT_ID", "CATEGORY_NAME", "DESCRIPTION", "IMAGE_URL", "NAME", "PRICE" },
                values: new object[,]
                {
                    { 2L, "T-shirt", "Utilizadades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg?raw", "Camiseta No Internet", 699.0 },
                    { 3L, "Action Figure", "Utilizadades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw", "Capacete Darth Vader Star Wars Black Series", 99999.0 },
                    { 4L, "Action Figure", "Utilizadades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw", "Star Wars The Black Series Hasbro - Stormtrooper Imperial", 18999.0 },
                    { 5L, "T-shirt", "Utilizadades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw", "Camiseta Gamer", 6999.0 },
                    { 6L, "T-shirt", "Utilizadades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw", "Camiseta SpaceX", 4999.0 },
                    { 7L, "T-shirt", "Utilizadades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw", "Camiseta Feminina Coffee Benefits", 699.0 },
                    { 8L, "Sweatshirt", "Utilizadades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw", "Moletom Com Capuz Cobra Kai", 1599.0 },
                    { 9L, "Book", "Utilizadades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw", "Livro Star Talk – Neil DeGrasse Tyson", 499.0 },
                    { 10L, "Action Figure", "Utilizadades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw", "Star Wars Mission Fleet Han Solo Nave Milennium Falcon", 35999.0 },
                    { 11L, "T-shirt", "Utilizadades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw", "Camiseta Elon Musk Spacex Marte Occupy Mars", 5999.0 },
                    { 12L, "T-shirt", "Utilizadades", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw", "Camiseta GNU Linux Programador Masculina", 5999.0 },
                    { 13L, "T-shirt", "Utilizadades", "\"https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg\"\",\"", "Camiseta Goku Fases", 5999.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "PRODUCT",
                keyColumn: "PRODUCT_ID",
                keyValue: 13L);
        }
    }
}
