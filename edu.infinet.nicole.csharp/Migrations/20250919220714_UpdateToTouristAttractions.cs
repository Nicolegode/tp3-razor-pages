using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace edu.infinet.nicole.csharp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateToTouristAttractions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "Code", "CountryName", "Population" },
                values: new object[,]
                {
                    { 1, "Brasília", "BR", "Brasil", 215000000L },
                    { 2, "Buenos Aires", "AR", "Argentina", 45000000L },
                    { 3, "Paris", "FR", "França", 68000000L },
                    { 4, "Madrid", "ES", "Espanha", 47000000L },
                    { 5, "Roma", "IT", "Itália", 60000000L },
                    { 6, "Lisboa", "PT", "Portugal", 10000000L },
                    { 7, "Washington", "US", "Estados Unidos", 331000000L },
                    { 8, "Ottawa", "CA", "Canadá", 38000000L },
                    { 9, "Cidade do México", "MX", "México", 128000000L },
                    { 10, "Santiago", "CL", "Chile", 19000000L }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CityName" },
                values: new object[,]
                {
                    { 1, 1, "Rio de Janeiro" },
                    { 2, 1, "São Paulo" },
                    { 3, 2, "Buenos Aires" },
                    { 4, 2, "Mendoza" },
                    { 5, 3, "Paris" },
                    { 6, 3, "Nice" },
                    { 7, 4, "Barcelona" },
                    { 8, 4, "Sevilha" },
                    { 9, 5, "Roma" },
                    { 10, 5, "Florença" },
                    { 11, 6, "Lisboa" },
                    { 12, 6, "Porto" },
                    { 13, 7, "Nova York" },
                    { 14, 7, "Miami" },
                    { 15, 8, "Toronto" },
                    { 16, 8, "Vancouver" },
                    { 17, 9, "Cancún" },
                    { 18, 9, "Playa del Carmen" },
                    { 19, 10, "Santiago" },
                    { 20, 10, "Valparaíso" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "CityId", "PropertyName", "PricePerNight" },
                values: new object[,]
                {
                    { 1, 1, "Pão de Açúcar", 280.00m },
                    { 2, 1, "Cristo Redentor", 180.00m },
                    { 3, 2, "MASP", 220.00m },
                    { 4, 3, "Caminito", 150.00m },
                    { 5, 4, "Aconcágua", 120.00m },
                    { 6, 5, "Torre Eiffel", 450.00m },
                    { 7, 6, "Promenade des Anglais", 320.00m },
                    { 8, 7, "Sagrada Família", 290.00m },
                    { 9, 8, "Alcázar de Sevilha", 160.00m },
                    { 10, 9, "Coliseu", 380.00m },
                    { 11, 10, "Ponte Vecchio", 340.00m },
                    { 12, 11, "Torre de Belém", 140.00m },
                    { 13, 12, "Livraria Lello", 110.00m },
                    { 14, 13, "Estátua da Liberdade", 520.00m },
                    { 15, 14, "South Beach", 380.00m },
                    { 16, 15, "CN Tower", 240.00m },
                    { 17, 16, "Stanley Park", 200.00m },
                    { 18, 17, "Chichen Itzá", 350.00m },
                    { 19, 18, "Cenotes", 280.00m },
                    { 20, 19, "Cerro San Cristóbal", 160.00m },
                    { 21, 20, "Casa Pablo Neruda", 130.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
