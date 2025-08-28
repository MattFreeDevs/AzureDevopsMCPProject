using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiLibreriaWebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedReadBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CountryId", "GenreId", "ISBN", "ReadingStatus", "Title" },
                values: new object[,]
                {
                    { 1, "Fyodor Dostoevsky", 9, 1, "9780140449136", 2, "Crime and Punishment" },
                    { 2, "John Kennedy Toole", 3, 1, "9788433971802", 2, "A Confederacy of Dunces" },
                    { 3, "Giuseppe Tomasi di Lampedusa", 23, 9, "9788435008910", 2, "The Leopard" },
                    { 4, "Yuval Noah Harari", 99, 2, "9780062316097", 2, "Sapiens" },
                    { 5, "Thomas Mann", 19, 1, "9788499893466", 2, "The Magic Mountain" },
                    { 6, "Gaston Leroux", 22, 1, "9780141191508", 2, "The Phantom of the Opera" },
                    { 7, "H.G. Wells", 21, 5, "9780141439983", 2, "The Invisible Man" },
                    { 8, "Mary Shelley", 21, 5, "9780141439471", 2, "Frankenstein" },
                    { 9, "Robert Louis Stevenson", 21, 14, "9780141439822", 2, "Treasure Island" },
                    { 10, "Edmund Burke", 21, 20, "9788498791749", 2, "Reflections on the Revolution in France" },
                    { 11, "María Elvira Roca Barea", 30, 20, "9788491640686", 2, "Imperiofobia" },
                    { 12, "George Orwell", 21, 1, "9788499890946", 2, "Animal Farm" },
                    { 13, "George Orwell", 21, 1, "9788499890946", 2, "1984" },
                    { 14, "José Saramago", 88, 1, "9788466368066", 2, "Blindness" },
                    { 15, "Daron Acemoglu, James A. Robinson", 3, 2, "9780307719225", 2, "Why Nations Fail" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
